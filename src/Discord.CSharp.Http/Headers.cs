using System.Text.Json;
using System.Text.RegularExpressions;

namespace Discord.CSharp.Http
{
    public class Headers
    {
        private readonly Dictionary<string, string> _headers = new();

        public void Add(string key, string value)
        {
            _headers[key] = value;
        }

        public bool Remove(string key)
        {
            return _headers.Remove(key);
        }

        public bool Contains(string key)
        {
            return _headers.ContainsKey(key);
        }

        public void Clear()
        {
            _headers.Clear();
        }

        public string? Get(string key)
        {
            return _headers.TryGetValue(key, out var value) ? value : null;
        }

        public IEnumerable<KeyValuePair<string, string>> GetALLParis()
        {
            return _headers;
        }

        public override string ToString()
        {
            return string.Join("\r\n", _headers.Select(header => $"{header.Key}: {header.Value}"));
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(_headers);
        }

        public static Headers FromJson(string json)
        {
            var dict = JsonSerializer.Deserialize<Dictionary<string, string>>(json) ?? new Dictionary<string, string>();
            Headers headers = new();
            foreach (var kvp in dict)
            {
                headers.Add(kvp.Key, kvp.Value);
            }
            return headers;
        }

        public static Headers Parse(string headersText)
        {
            Headers headers = new();
            foreach (var line in headersText.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                var match = Regex.Match(line, @"^(.*?):\s*(.*)$");
                if (match.Success)
                {
                    headers.Add(match.Groups[1].Value, match.Groups[2].Value);
                }
            }
            return headers;
        }

        public void Merge(Headers other, bool overwrite = true)
        {
            foreach (var kvp in other.GetALLParis())
            {}
        }
    }
}