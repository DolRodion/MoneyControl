using MediatR;
using MoneyControll.Application.Common.Responces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyControll.Application.Features.Sending.GetSendings
{
    public class GetSendingsQuery : IRequest<Response>
    {
    }
}
