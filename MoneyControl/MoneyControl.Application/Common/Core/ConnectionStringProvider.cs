using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyControl.Application.Common.Core
{
    public class ConnectionStringProvider : IConnectionStringProvider
    {
        private readonly IConfiguration _configuration;

        public ConnectionStringProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnectionString(DataBaseConnectionEnum dataBaseKey)
        {
            switch (dataBaseKey)
            {
                //Главное 
                case DataBaseConnectionEnum.MainDataBase:
                    return _configuration.GetConnectionString(ConnectionStringConst.MainDataBaseConnection);

                default:
                    return string.Empty;
            }
        }
    }
}
