using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WorkshopThirdPart
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var responseBody = await MM2Client.ProcessElectrum("RICK", new Server[]
                {
                    new Server {Url = "electrum1.cipig.net:10017"},
                    new Server {Url = "electrum2.cipig.net:10017"},
                    new Server {Url = "electrum3.cipig.net:10017"}
                });

                var answer = ElectrumAnswer.FromJson(responseBody);
                Console.WriteLine(responseBody);

                responseBody = await MM2Client.ProcessElectrum("MORTY", new Server[]
                {
                    new Server {Url = "electrum1.cipig.net:10018"},
                    new Server {Url = "electrum2.cipig.net:10018"},
                    new Server {Url = "electrum3.cipig.net:10018"}
                });
                Console.WriteLine(responseBody);

                responseBody = await MM2Client.ProcessBalance("RICK");
                Console.WriteLine(responseBody);

                responseBody = await MM2Client.ProcessBalance("MORTY");
                Console.WriteLine(responseBody);

                responseBody = await MM2Client.ProcessOrderbook("RICK", "MORTY");
                var parsedJson = JsonConvert.DeserializeObject(responseBody);
                Console.WriteLine(JsonConvert.SerializeObject(parsedJson, Formatting.Indented));

                responseBody = await MM2Client.ProcessWithdraw("RICK", "0.1", answer.Address);
                Console.WriteLine(responseBody);

                var withdrawAnswer = WithdrawAnswer.FromJson(responseBody);
                Console.WriteLine("\n TX HEX: " + withdrawAnswer.TxHex);

                responseBody = await MM2Client.ProcessSendRawTransaction(withdrawAnswer.Coin, withdrawAnswer.TxHex);
                Console.WriteLine(responseBody);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}