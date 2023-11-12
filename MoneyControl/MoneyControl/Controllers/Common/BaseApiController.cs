using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using MoneyControll.Application.Common.Enum;
using MoneyControll.Application.Common.Responces;
using System;
using System.Threading.Tasks;

namespace MoneyControl.Controllers.Common
{
    public abstract class BaseApiController: ControllerBase
    {
        private IMediator _mediator;

        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

        [ApiExplorerSettings(IgnoreApi = true)]
        [NonAction]
        public async Task<Response> CustomHandler(IRequest<Response> query)
        {
            try
            {
                return await Mediator.Send(query);
            }
            catch (Exception)
            {
                return new Response(HttpResponseEnum.ServerError);
            }
        }
    }
}
