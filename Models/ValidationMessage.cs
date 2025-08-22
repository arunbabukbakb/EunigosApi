namespace EunigosApi.Models
{
    public class Error
    {
        public string Field { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
    }
}
