﻿
using MediatR;
using MoneyControll.Application.Common.Responces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyControl.Command.Spending.GetSpendings
{
    public class GetSpendingsQuery : IRequest<Response>
    {
    }
}