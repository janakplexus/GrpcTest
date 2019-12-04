using Grpc.Core;
using GrpcServer.Protos;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace GrpcServer.Services
{
    public class CalculationService : Calculation.CalculationBase
    {
        private readonly ILogger<GreeterService> _logger;
        public CalculationService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<CalcResponse> Add(CalcRequest request, ServerCallContext context)
        {
            return Task.FromResult(new CalcResponse
            {
                Result = request.FirstNumber + request.SecondNumber
            });
        }

        public override Task<CalcResponse> Multiply(CalcRequest request, ServerCallContext context)
        {
            return Task.FromResult(new CalcResponse
            {
                Result = request.FirstNumber * request.SecondNumber
            });
        }

    }
}
