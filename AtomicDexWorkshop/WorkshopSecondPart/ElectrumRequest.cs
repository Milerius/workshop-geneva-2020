using Newtonsoft.Json;

namespace WorkshopSecondPart
{
    public partial class ElectrumRequest
    {
        [JsonProperty("userpass")]
        public string Userpass { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("coin")]
        public string Coin { get; set; }

        [JsonProperty("servers")]
        public Server[] Servers { get; set; }
    }

    public partial class Server
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class ElectrumRequest
    {
        public static ElectrumRequest FromJson(string json) => JsonConvert.DeserializeObject<ElectrumRequest>(json, Converter.Settings);
    }
    
    public static partial class Serialize
    {
        public static string ToJson(this ElectrumRequest self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings();
    }
}
