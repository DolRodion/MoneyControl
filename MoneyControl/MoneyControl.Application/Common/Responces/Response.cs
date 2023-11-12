using MoneyControll.Application.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyControll.Application.Common.Responces
{
    public class Response
    {
        public Response()
        {
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="errors">Ошибки обработки запроса.</param>
        public Response(string errors)
        {
            IsSuccess = false;
            Errors = errors;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Response(HttpResponseEnum code)
        {
            IsSuccess = false;
            Code = code;
        }

        /// <inheritdoc/>
        public string Errors { get; set; } = string.Empty;

        /// <inheritdoc/>
        public bool IsSuccess { get; set; }

        /// <inheritdoc/>
        public object Id { get; set; } = 0;

        /// <summary>
        /// Идентификатор ошибки
        /// </summary> 
        public HttpResponseEnum? Code { get; set; }

        /// <summary>
        /// Возвращает успешный результат запроса
        /// </summary>
        /// <returns></returns>
        public static Response GetSuccessResponse()
        {
            return new Response() { IsSuccess = true };
        }
    }
}
