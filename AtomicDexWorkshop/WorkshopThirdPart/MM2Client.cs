using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WorkshopThirdPart
{
    public static class MM2Client
    {
        private static readonly HttpClient Client = new HttpClient();

        private static async Task<string> ProcessRequest(string req)
        {
            var response = await Client.PostAsync("http://127.0.0.1:7783",
                new StringContent(req, Encoding.UTF8, "application/json"));

            var s = await response.Content.ReadAsStringAsync();
            return s;
        }

        public static async Task<string> ProcessElectrum(string ticker, Server[] servers)
        {
            var req = new ElectrumRequest
            {
                Coin = ticker,
                Servers = servers,
                Method = "electrum",
                Userpass = "your_passphrase_here"
            };

            return await ProcessRequest(req.ToJson());
        }

        public static async Task<string> ProcessBalance(string ticker)
        {
            var req = new BalanceRequest
            {
                Coin = ticker,
                Method = "my_balance",
                Userpass = "your_passphrase_here"
            };

            return await ProcessRequest(req.ToJson());
        }

        public static async Task<string> ProcessOrderbook(string relTicker, string baseTicker)
        {
            var req = new OrderbookRequest
            {
                Rel = relTicker,
                Base = baseTicker,
                Method = "orderbook",
                Userpass = "your_passphrase_here"
            };

            return await ProcessRequest(req.ToJson());
        }
    }
}