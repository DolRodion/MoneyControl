using MoneyControll.Application.Common.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyControll.Application.Common.Responces
{
    public class ModelResponse<T>
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="model">Модель данных</param>
        /// <param name="isSuccess">Признак успешной обработки запроса</param>
        public ModelResponse(T model, bool isSuccess = true)
        {
            ResponseModel = model;
            IsSuccess = isSuccess;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="errors">Ошибки во время выполнения запроса</param>
        public ModelResponse(string errors)
        {
            IsSuccess = false;
            Errors = errors;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        public ModelResponse(HttpResponseEnum code)
        {
            IsSuccess = false;
            Code = code;
        }

        /// <summary>
        /// Ошибки во время выполнения запроса
        /// </summary>
        public string Errors { get; set; } = string.Empty;

        /// <summary>
        /// Признак наличия ошибок при обработке запроса
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Идентификатор ошибки
        /// </summary> 
        public HttpResponseEnum? Code { get; set; }

        /// <summary>
        /// Результирующая модель
        /// </summary>
        public T ResponseModel { get; set; }
    }
}
