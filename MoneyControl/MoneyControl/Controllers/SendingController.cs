using MoneyControl.Controllers.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using MoneyControll.Application.Common.Responces;
using MoneyControll.Application.Features.Sending.GetSendings;

namespace MoneyControl.WebApi.Controllers
{
    [Route("[controller]")]
    public class SendingController: BaseApiController
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response))]
        [Route("GetDevices")]
        public async Task<IActionResult> GetSendingsAsync()
        {
            return Ok(await CustomHandler(new GetSendingsQuery()));
        }
    }
}
