using System.Text.RegularExpressions;

namespace Discord.CSharp.Http
{
    public  interface IUserAgentComponent
    {
        string Name { get; }
        string Version { get; }
        string ToString();
    }

    public abstract record UserAgentComponent(string Name, string Version);
    public record OS(string Name, string Version) : UserAgentComponent(Name, Version);
    public record Browser(string Name, string Version) : UserAgentComponent(Name, Version);    
    public record Engine(string Name, string Version) : UserAgentComponent(Name, Version);
    
    public class UserAgent
    {
        public OS OS { get; set; }
        public Browser Browser { get; set; }
        public Engine Engine { get; set; }

        public UserAgent(OS os, Browser browser, Engine engine)
        {
            OS = os;
            Browser = browser;
            Engine = engine;
        }
        
       public static UserAgent Parse(string userAgent)
        {   
            var os = ParseOS(userAgent);
            var browser = ParseBrowser(userAgent);
            var engine = ParseEngine(userAgent);

            return new UserAgent(os, browser, engine);
        }

        public static OS ParseOS(string userAgent)
        {
            var osList = new Dictionary<string, string>
            {
                { "Windows", @"Windows NT ([\d.]+)" },
                { "macOS", @"Mac OS X ([\d_]+)" },
                { "Linux", @"Linux" }
            };

            return MatchUserAgentComponent(userAgent, osList, name => new OS(name, "N/A"));
        }

        public static Browser ParseBrowser(string userAgent)
        {
            var browsers = new Dictionary<string, string>
            {
                { "Chrome", @"Chrome/([\d.]+)" },
                { "Firefox", @"Firefox/([\d.]+)" },
                { "Edge", @"Edg/([\d.]+)" },
                { "Safari", @"Version/([\d.]+).*Safari" },
                { "Opera", @"OPR/([\d.]+)" }
            };

            return MatchUserAgentComponent(userAgent, browsers, name => new Browser(name, "N/A"));
        }

        public static Engine ParseEngine(string userAgent)
        {
            var browsers = new Dictionary<string, string>
            {
                { "Blink", @"(Chrome|Chromium|OPR|Edg)/([\d.]+)" },
                { "WebKit", @"AppleWebKit/([\d.]+)" },
                { "Gecko", @"Gecko/([\d.]+)" }, 
            };

            return MatchUserAgentComponent(userAgent, browsers, name => new Engine(name, "N/A"));
        }

        private static T MatchUserAgentComponent<T>(string userAgent, Dictionary<string, string> patterns, Func<string, T> factory) where T : UserAgentComponent
        {
            foreach (var (name, pattern) in patterns)
            {
                var match = Regex.Match(userAgent, pattern);
                if(match.Success)
                {
                    int groupCount = match.Groups.Count;
                    int versionGroupIndex = groupCount > 1 ? groupCount - 1 : -1;

                    string version = (match.Groups.Count > 1 && match.Groups[versionGroupIndex].Success) ? match.Groups[versionGroupIndex].Value.Replace('_', '.') : "N/A";
                    return factory(name) with { Version = version };
                }
            }

            return factory("Unknwon");
        }
    }
}