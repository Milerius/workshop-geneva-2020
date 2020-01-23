using Newtonsoft.Json;

namespace WorkshopThirdPart
{
    public partial class SendRawTransactionRequest
    {
        [JsonProperty("method")] public string Method { get; set; }

        [JsonProperty("coin")] public string Coin { get; set; }

        [JsonProperty("tx_hex")] public string TxHex { get; set; }

        [JsonProperty("userpass")] public string Userpass { get; set; }
    }

    public partial class SendRawTransactionRequest
    {
        public static SendRawTransactionRequest FromJson(string json) =>
            JsonConvert.DeserializeObject<SendRawTransactionRequest>(json, Converter.Settings);
    }

    public static partial class Serialize
    {
        public static string ToJson(this SendRawTransactionRequest self) =>
            JsonConvert.SerializeObject(self, Converter.Settings);
    }
}