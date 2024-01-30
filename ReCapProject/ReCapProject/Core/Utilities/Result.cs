using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class Result : IResult
    {
        // Hem başarılı başarısız bilgisi hem de mesaj döndüren constructor
        public Result(bool success, string message) :this(success)
        {
            Message = Message;
        }

        // Yalnızca başarılı başarısız bilgisi döndüren constructor
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get;  }
    }
}
