using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoneyControl.Command.Spending.GetSpendings;
using MoneyControl.Controllers.Common;
using MoneyControll.Application.Common.Responces;
using System.Threading.Tasks;

namespace MoneyControl.WebApi.Controllers
{
    [Route("[controller]")]
    public class SpendingController: BaseApiController
    {
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response))]
        [Route("GetDevices")]
        public async Task<IActionResult> GetSpendingsAsync()
        {
            return Ok(await CustomHandler(new GetSpendingsQuery()));
        }
    }
}
