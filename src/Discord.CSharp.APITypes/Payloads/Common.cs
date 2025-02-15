

namespace Discord.CSharp.APITypes.Payloads
{
    public enum PermissionFlagsBits
    {
        
    }

    public class RESTError
    {
        public int Code { get; set; }
        public required string Message { get; set; }
        public RESTErrorData? Errors { get; set; }
    }

    public class RESTErrorFieldInformation
    {
        public required string Code { get; set; }
        public required string Message { get; set; }
    }

    public class RESTERRORGroupWrapper
    {
        public required List<RESTErrorData> Errors { get; set; }
    }

    public class RESTErrorData
    {
        public RESTErrorFieldInformation? FieldInformation { get; set; }
        public RESTERRORGroupWrapper? GroupWrapper { get; set; }
        public string? ErrorMessage { get; set; }
        public Dictionary<string, RESTErrorData>? NestedErrors { get; set; }
    }

    public class RESTRateLimit
    {
        public int? Code { get; set; }
        public bool Global { get; set; }
        public required string Message { get; set; }
        public double RetryAfter { get; set; }
    }
}