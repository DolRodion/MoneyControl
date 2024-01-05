using Dapper;
using MediatR;
using MoneyControl.Application.Common.Core;
using MoneyControll.Application.Common.Responces;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MoneyControl.Command.Spending.GetSpendings
{
    public class GetSpendingsQueryHandler : IRequestHandler<GetSpendingsQuery, Response>
    {
        private readonly IConnectionStringProvider _connectionStringProvider;

        public GetSpendingsQueryHandler(IConnectionStringProvider connectionStringProvider)
        {
            _connectionStringProvider = connectionStringProvider;
        }

        public async Task<Response> Handle(GetSpendingsQuery request, CancellationToken cancellationToken)
        {
            try
            {
                using (IDbConnection dbConnection = new NpgsqlConnection(_connectionStringProvider.GetConnectionString(DataBaseConnectionEnum.MainDataBase)))
                {
                    string query = @"SELECT id, name
                     FROM public.spending_categories";

                    var result = (await dbConnection.QueryAsync(query)).ToArray();

                    return new Response();
                }

            }
            catch (Exception)
            {
                return new Response("Ошибка сервера");
            }
        }
    }
}
