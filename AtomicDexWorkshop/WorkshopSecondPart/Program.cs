﻿using System;
using System.Threading.Tasks;

namespace WorkshopSecondPart
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            var responseBody = await MM2Client.ProcessElectrum();
            Console.WriteLine(responseBody);
        }
    }
}