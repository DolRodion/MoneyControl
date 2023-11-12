using MediatR;
using MoneyControll.Application.Common.Responces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MoneyControll.Application.Features.Sending.GetSendings
{
    public class GetSendingsQueryHandler : IRequestHandler<GetSendingsQuery, Response>
    {
        public async Task<Response> Handle(GetSendingsQuery deviceQuery, CancellationToken cancellationToken)
        {
            try
            {
                return Response.GetSuccessResponse();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
