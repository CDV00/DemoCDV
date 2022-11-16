using System.Collections.Generic;

namespace SER.Infrastructure.ViewModel.Reponse
{
    public class Reponses<T>
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public int? TotalRow { get; set; }
        public List<T>? Data { get; set; }

        
        public Reponses(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
        public Reponses(bool isSuccess, string message, int totalRow, List<T> data)
        {
            IsSuccess = isSuccess;
            Data = data;
            Message = message;
            TotalRow = totalRow;
        }
        public Reponses(bool isSuccess, string message,List<T> data)
        {
            IsSuccess = isSuccess;
            Data = data;
            Message = message;
        }
    }
}
