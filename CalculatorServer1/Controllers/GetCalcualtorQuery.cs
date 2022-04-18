using AutoMapper;
using MediatR;

namespace CalculatorServer1.Controllers
{
    public class GetCalcualtorQuery : IRequest<double>
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string Operation { get; set; }
    }
    public class GetCalcualtorQueryHandler : IRequestHandler<GetCalcualtorQuery, double>
    {
        public Task<double> Handle(GetCalcualtorQuery request, CancellationToken cancellationToken)
        {
            var x = request.Operation switch
            {
                "add" => request.Num1 + request.Num2,
                "subtract" => request.Num1 - request.Num2,
                "multiply" => request.Num1 * request.Num2,
                "divide" => request.Num1 / request.Num2,
            };

            return Task.FromResult(x);

        }
    }
}