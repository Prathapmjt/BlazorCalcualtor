using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorServer1.Controllers
{
   
    [Route("api/calculator/num1/{num1}/num2/{num2}/opearton/{operation}")]
    public class CalculatorController : BaseController
    {
        [HttpGet]
        public async Task<double> Get(double num1, double num2, string operation)
        {
            var query = new GetCalcualtorQuery { Num1 = num1, Num2 = num2, Operation = operation };
            return await Mediator.Send(query);
        }
    }
}
