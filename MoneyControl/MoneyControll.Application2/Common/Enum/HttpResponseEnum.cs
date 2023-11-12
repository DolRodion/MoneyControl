using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyControll.Application.Common.Enum
{
    public enum HttpResponseEnum
    {
        /// <summary>
        /// Произошла ошибка. Сессия устарела
        /// </summary>
        [Description("Произошла ошибка. Сессия устарела")]
        SessionExpired = 401,

        /// <summary>
        /// Произошла ошибка. Не корректные параметры запроса
        /// </summary>
        [Description("Произошла ошибка. Не корректные параметры запроса")]
        UnsupportedMedia = 415,

        /// <summary>
        /// Произошла ошибка. Отказано в доступе
        /// </summary>
        [Description("Произошла ошибка. Отказано в доступе")]
        AcceesDenied = 403,

        /// <summary>
        /// Произошла ошибка. Ошибка сервера
        /// </summary>
        [Description("Произошла ошибка. Ошибка сервера")]
        ServerError = 500,
    }
}
