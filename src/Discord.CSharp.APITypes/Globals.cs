global using Snowflake = System.String;

using System.Text.RegularExpressions;

namespace Discord.CSharp.APITypes
{
    public record Snowflake(string Value);

    public static class FormattingPatterns
    {
        public static readonly Regex User = new Regex(@"<@(?<id>\d{17,20})>");
    }
}