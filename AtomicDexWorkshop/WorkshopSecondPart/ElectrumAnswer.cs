using Newtonsoft.Json;

namespace WorkshopSecondPart
{
    public partial class Welcome
    {
        [JsonProperty("address", Required = Required.Always)]
        public string Address { get; set; }

        [JsonProperty("balance", Required = Required.Always)]
        public string Balance { get; set; }

        [JsonProperty("coin", Required = Required.Always)]
        public string Coin { get; set; }

        [JsonProperty("locked_by_swaps", Required = Required.Always)]
        public string LockedBySwaps { get; set; }

        [JsonProperty("required_confirmations", Required = Required.Always)]
        public long RequiredConfirmations { get; set; }

        [JsonProperty("result", Required = Required.Always)]
        public string Result { get; set; }
    }

    public partial class Welcome
    {
        public static Welcome FromJson(string json) => JsonConvert.DeserializeObject<Welcome>(json, Converter.Settings);
    }

    public static partial class Serialize
    {
        public static string ToJson(this Welcome self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }
}