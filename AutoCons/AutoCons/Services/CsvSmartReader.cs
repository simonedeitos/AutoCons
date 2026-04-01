using System.Data;
using System.Text;

namespace AutoCons.Services
{
    public static class CsvSmartReader
    {
        public static DataTable Read(string filePath)
        {
            var encoding = DetectEncoding(filePath);
            var lines = File.ReadAllLines(filePath, encoding)
                            .Where(l => !string.IsNullOrWhiteSpace(l))
                            .ToArray();

            if (lines.Length == 0) return new DataTable();

            char separator = DetectSeparator(lines);

            // If no separator found, treat each line as a single value
            if (separator == '\0')
            {
                return BuildSingleColumnTable(lines);
            }

            return BuildTable(lines, separator);
        }

        public static List<string> ReadPhoneNumbers(string filePath)
        {
            var encoding = DetectEncoding(filePath);
            var lines = File.ReadAllLines(filePath, encoding)
                            .Where(l => !string.IsNullOrWhiteSpace(l))
                            .ToArray();

            if (lines.Length == 0) return new List<string>();

            char separator = DetectSeparator(lines);

            var numbers = new List<string>();

            if (separator == '\0')
            {
                // One number per line
                foreach (var line in lines)
                    numbers.Add(line.Trim().TrimEnd(';').Trim());
            }
            else
            {
                foreach (var line in lines)
                {
                    var parts = line.Split(separator);
                    foreach (var part in parts)
                    {
                        var val = part.Trim().TrimEnd(';').Trim();
                        if (!string.IsNullOrWhiteSpace(val))
                            numbers.Add(val);
                    }
                }
            }

            return numbers.Where(n => !string.IsNullOrWhiteSpace(n)).ToList();
        }

        public static (DataTable table, char separator, bool hasHeader) ReadWithMeta(string filePath)
        {
            var encoding = DetectEncoding(filePath);
            var lines = File.ReadAllLines(filePath, encoding)
                            .Where(l => !string.IsNullOrWhiteSpace(l))
                            .ToArray();

            if (lines.Length == 0)
                return (new DataTable(), ',', false);

            char separator = DetectSeparator(lines);
            if (separator == '\0') separator = ',';

            bool hasHeader = DetectHeader(lines, separator);
            var table = BuildTable(lines, separator, hasHeader);
            return (table, separator, hasHeader);
        }

        private static Encoding DetectEncoding(string filePath)
        {
            // Check BOM first
            using (var fs = File.OpenRead(filePath))
            {
                var bom = new byte[4];
                int read = fs.Read(bom, 0, 4);

                if (read >= 3 && bom[0] == 0xEF && bom[1] == 0xBB && bom[2] == 0xBF)
                    return Encoding.UTF8;
                if (read >= 2 && bom[0] == 0xFF && bom[1] == 0xFE)
                    return Encoding.Unicode;
                if (read >= 2 && bom[0] == 0xFE && bom[1] == 0xFF)
                    return Encoding.BigEndianUnicode;
            }

            // Try to detect if it's valid UTF-8 (open a new stream after BOM check is complete)
            try
            {
                using var reader = new StreamReader(filePath, new UTF8Encoding(false, true));
                reader.ReadToEnd();
                return Encoding.UTF8;
            }
            catch
            {
                return Encoding.Latin1;
            }
        }

        private static char DetectSeparator(string[] lines)
        {
            var candidates = new[] { ';', ',', '\t', '|' };
            var sampleLines = lines.Take(Math.Min(10, lines.Length)).ToArray();

            foreach (var sep in candidates)
            {
                var counts = sampleLines.Select(l => l.Count(c => c == sep)).ToArray();
                if (counts.All(c => c > 0) && counts.Distinct().Count() <= 2)
                    return sep;
            }

            // Check if any separator appears at all
            foreach (var sep in candidates)
            {
                if (sampleLines.Any(l => l.Contains(sep)))
                    return sep;
            }

            return '\0'; // One value per line
        }

        private static bool DetectHeader(string[] lines, char separator)
        {
            if (lines.Length < 2) return false;
            var firstParts = lines[0].Split(separator);
            var secondParts = lines[1].Split(separator);

            // If first row has non-numeric values but second has numeric, likely header
            bool firstHasText = firstParts.Any(p => !double.TryParse(p.Trim(), out _) && !string.IsNullOrWhiteSpace(p));
            return firstHasText;
        }

        private static DataTable BuildSingleColumnTable(string[] lines)
        {
            var table = new DataTable();
            table.Columns.Add("Value", typeof(string));
            foreach (var line in lines)
                table.Rows.Add(line.Trim().TrimEnd(';').Trim());
            return table;
        }

        private static DataTable BuildTable(string[] lines, char separator, bool hasHeader = true)
        {
            var table = new DataTable();
            if (lines.Length == 0) return table;

            var firstRow = lines[0].Split(separator);

            if (hasHeader)
            {
                foreach (var col in firstRow)
                    table.Columns.Add(col.Trim(), typeof(string));

                for (int i = 1; i < lines.Length; i++)
                {
                    var parts = lines[i].Split(separator);
                    var row = table.NewRow();
                    for (int j = 0; j < table.Columns.Count; j++)
                        row[j] = j < parts.Length ? parts[j].Trim() : string.Empty;
                    table.Rows.Add(row);
                }
            }
            else
            {
                // Auto-generate column names
                for (int i = 0; i < firstRow.Length; i++)
                    table.Columns.Add($"Column{i + 1}", typeof(string));

                foreach (var line in lines)
                {
                    var parts = line.Split(separator);
                    var row = table.NewRow();
                    for (int j = 0; j < table.Columns.Count; j++)
                        row[j] = j < parts.Length ? parts[j].Trim() : string.Empty;
                    table.Rows.Add(row);
                }
            }

            return table;
        }
    }
}
