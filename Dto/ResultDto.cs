using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventoPresupuestado.Dto
{
    public class ResultDto
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public bool IsFatal { get; set; }

        public static ResultDto Success(string message)
            => new ResultDto { IsSuccess = true, Message = message, IsFatal = false };

        public static ResultDto Warning(string message)
            => new ResultDto { IsSuccess = false, Message = message, IsFatal = false };

        public static ResultDto Fatal(string message)
            => new ResultDto { IsSuccess = false, Message = message, IsFatal = true };
    }
}
