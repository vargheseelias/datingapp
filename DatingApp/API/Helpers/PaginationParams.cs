namespace API.Helpers
{
    public class PaginationParams
    {
         private const int MaxPageSize = 50;
        public int pageNumber { get; set; } = 1;
        private int _PageSize = 10;
        public int PageSize
        {
            get => _PageSize;
            set => _PageSize = (value > MaxPageSize) ? MaxPageSize : value;
        }
    }
}