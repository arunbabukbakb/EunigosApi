namespace EunigosApi.Models.CommonModels
{
    public class PaginationDto
    {
        public int Total { get; set; }
        public int Limit { get; set; }
        public int Page { get; set; }
        public int Pages { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
    }
}
