using System.Text.Json;
using System.Text.RegularExpressions;

namespace Discord.CSharp.Http
{
    public class Cookie
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public DateTime? Expires { get; set; }
        public string? Domain { get; set; }
        public string? Path { get; set; }
        public bool Secure { get; set; }
        public bool HttpOnly { get; set; }

        public Cookie(string name, string value, DateTime? expires = null, string? domain = null, string? path = "/", bool secure = false, bool httpOnly = false)
        {
            Name = name;
            Value = value;
            Expires = expires;
            Domain = domain;
            Path = path;
            Secure = secure;
            HttpOnly = httpOnly;
        }

        public override string ToString()
        {
            List<string> parts = new() { $"{Name}={Value}"};

            if (Expires.HasValue)
                parts.Add($"Expires={Expires.Value:R}");
            if (!string.IsNullOrEmpty(Domain))
                parts.Add($"Domain={Domain}");
            if (!string.IsNullOrEmpty(Path))
                parts.Add($"Path={Path}");
            if (Secure)
                parts.Add("Secure");
            if (HttpOnly)
                parts.Add("HttpOnly");

            return string.Join("; ", parts);
        }
    }

    public class Cookies
    {
        private readonly Dictionary<string, Cookie> _cookies = new();

        public void Add(string name, string value, DateTime? expires = null, string? domain = null, string? path = "/", bool secure = false, bool httpOnly = false)
        {
            _cookies[name] = new Cookie(name, value, expires, domain, path, secure, httpOnly);   
        }

        public bool Remove(string name)
        {
            return _cookies.Remove(name);
        }

        public bool Contains(string name)
        {
            return _cookies.ContainsKey(name);
        }

        public string? Get(string name)
        {
            return _cookies.TryGetValue(name, out var cookie) ? cookie.Value : null;
        }

        public Dictionary<string, Cookie> GetAll()
        {
            return new Dictionary<string, Cookie>(_cookies);
        }

        public string ToHeaderString()
        {
            return string.Join(": ", _cookies.Values.Select(cookie => $"{cookie.Name}={cookie.Value}"));
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(_cookies.Values);
        }

        public static Cookies FromJson(string json)
        {
            var cookies = JsonSerializer.Deserialize<List<Cookie>>(json) ?? new List<Cookie>();
            Cookies cookiesCollection = new();
            foreach (var cookie in cookies)
            {
                cookiesCollection._cookies[cookie.Name] = cookie;
            }
            return cookiesCollection;
        }

        public static Cookies Parse(string cookieHeader)
        {
            Cookies cookies = new();
            foreach (var part in cookieHeader.Split(new[] { "\r\n", "\n", "; " }, StringSplitOptions.RemoveEmptyEntries))
            {
                var match = Regex.Match(part.Trim(), @"^([^=]+)=([^;]+)");
                if (match.Success)
                {
                    string name = match.Groups[1].Value.Trim();
                    string value = match.Groups[2].Value.Trim();
                    cookies.Add(name, value);
                }
            }
            return cookies;
        }

        public void Merge(Cookies other, bool overwrite = true)
        {
            foreach (var kvp in other.GetAll())
            {
                if (overwrite || !_cookies.ContainsKey(kvp.Key))
                {
                    _cookies[kvp.Key] = kvp.Value;
                }
            }
        }
    }
}