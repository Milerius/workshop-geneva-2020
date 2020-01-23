using Newtonsoft.Json;

namespace WorkshopThirdPart
{
    public partial class OrderbookRequest
    {
        [JsonProperty("userpass")] public string Userpass { get; set; }

        [JsonProperty("method")] public string Method { get; set; }

        [JsonProperty("base")] public string Base { get; set; }

        [JsonProperty("rel")] public string Rel { get; set; }
    }

    public partial class OrderbookRequest
    {
        public static OrderbookRequest FromJson(string json) =>
            JsonConvert.DeserializeObject<OrderbookRequest>(json, Converter.Settings);
    }

    public static partial class Serialize
    {
        public static string ToJson(this OrderbookRequest self) =>
            JsonConvert.SerializeObject(self, Converter.Settings);
    }
}