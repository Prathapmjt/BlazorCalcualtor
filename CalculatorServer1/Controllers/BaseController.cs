using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorServer1.Controllers
{

    [ApiController]
    public class BaseController : Controller
    {
        private readonly Lazy<IMediator> _mediatorLazy;
        public BaseController()
        {
            _mediatorLazy = new Lazy<IMediator>(() => HttpContext.RequestServices.GetService<IMediator>());
        }
        public IMediator Mediator => _mediatorLazy.Value;
    }
}


