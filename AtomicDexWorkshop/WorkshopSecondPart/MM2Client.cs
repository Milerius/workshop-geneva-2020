using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WorkshopSecondPart;

namespace WorkshopSecondPart
{
    public static class MM2Client
    {
        private static readonly HttpClient Client = new HttpClient();
        
        public static async Task<string> ProcessElectrum()
        {
            var req = new ElectrumRequest
            {
                Coin = "RICK",
                Servers = new Server[]
                {
                    new Server {Url = "electrum1.cipig.net:10017"},
                    new Server {Url = "electrum2.cipig.net:10017"},
                    new Server {Url = "electrum3.cipig.net:10017"}
                },
                Method = "electrum",
                Userpass = "your_passphrase_here"
            };

            var response = await Client.PostAsync("http://127.0.0.1:7783",
                new StringContent(req.ToJson(), Encoding.UTF8, "application/json"));

            var s = await response.Content.ReadAsStringAsync();
            return s;
        }
    }
}