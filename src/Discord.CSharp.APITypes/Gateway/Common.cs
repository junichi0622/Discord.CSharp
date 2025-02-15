namespace Discord.CSharp.APITypes.Gateway
{
    public enum EncodingType
    {
        Etf,
        Json
    }

    public enum CompressType
    {
        ZlibStream
    }

    public class GatewayURLQuery
    {
        public required string V { get; set;}
        public required EncodingType Encoding { get; set; }
        public CompressType? Compress { get; set; }
    }
}