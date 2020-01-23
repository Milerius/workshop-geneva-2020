﻿using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WorkshopThirdPart
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            var responseBody = await MM2Client.ProcessElectrum("RICK", new Server[]
            {
                new Server {Url = "electrum1.cipig.net:10017"},
                new Server {Url = "electrum2.cipig.net:10017"},
                new Server {Url = "electrum3.cipig.net:10017"}
            });

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
        }
    }
}