using Grpc.Net.Client;
using GrpcServer.Protos;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Calculation.CalculationClient(channel);

            var addReply = await client.AddAsync(new CalcRequest { FirstNumber = 5, SecondNumber = 7 });
            Console.WriteLine($"Add Result: {addReply.Result}");

            var multiplyReply = await client.MultiplyAsync(new CalcRequest { FirstNumber = 5, SecondNumber = 7 });
            Console.WriteLine($"Multiplication Result: {multiplyReply.Result}");

            Console.ReadKey();
        }
    }
}
