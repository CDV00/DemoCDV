namespace SER.Infrastructure.ViewModel.Resquest
{
    public class ResquestPaging<T>
    {
        public int? PageIndex { get; set; }
        public int? PageSize { get; set; }
        public T Data { get; set; }
        public ResquestPaging(int pageIndex, int pageSiZe, T data)
        {
            PageIndex = pageIndex;
            PageSize = pageSiZe;
            Data = data;
        }


    }
}
