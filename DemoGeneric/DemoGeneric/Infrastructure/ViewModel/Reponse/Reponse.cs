using System;
using System.Linq;
using System.Threading.Tasks;

namespace DemoGeneric.Infrastructure.ViewModel.Reponse
{
    public class Reponse<T>
    {
        public string  Message { get; set; }
        public bool  IsSuccess { get; set; }
        public  T Data { get; set; }

        public Reponse(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
        public Reponse(bool isSuccess, string message, T data)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
        }

    }
}
