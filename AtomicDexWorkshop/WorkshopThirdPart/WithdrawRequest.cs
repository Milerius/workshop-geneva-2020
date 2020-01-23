using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WorkshopThirdPart
{
    public partial class WithdrawRequest
    {
        [JsonProperty("method")] public string Method { get; set; }

        [JsonProperty("coin")] public string Coin { get; set; }

        [JsonProperty("to")] public string To { get; set; }

        [JsonProperty("amount")] public string Amount { get; set; }

        [JsonProperty("userpass")] public string Userpass { get; set; }
    }

    public partial class WithdrawRequest
    {
        public static WithdrawRequest FromJson(string json) =>
            JsonConvert.DeserializeObject<WithdrawRequest>(json, Converter.Settings);
    }

    public static partial class Serialize
    {
        public static string ToJson(this WithdrawRequest self) =>
            JsonConvert.SerializeObject(self, Converter.Settings);
    }
}