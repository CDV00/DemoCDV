namespace SER.Infrastructure.ViewModel.Resquest
{
    public class Parameter
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public Parameter(int pageIndex = 1, int pageSiZe = 100)
        {
            PageIndex = pageIndex;
            PageSize = pageSiZe;
        }
    }
}
