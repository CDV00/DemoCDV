namespace SER.Infrastructure.ViewModel.Reponse
{
    public class BaseReponse
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }

        public BaseReponse(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
    }
}
