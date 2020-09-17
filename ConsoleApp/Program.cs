using ClassLibaries.Models;
using ClassLibaries.Services;
using Microsoft.Azure.Devices.Client;
using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {

        private static readonly string _conn = "";
        private static readonly DeviceClient deviceClient = DeviceClient
        .CreateFromConnectionString(_conn, TransportType.Mqtt);

        static void Main(string[] args)
        {
            DeviceService.SendMessageAsync(deviceClient).GetAwaiter();
        }
    }
}
