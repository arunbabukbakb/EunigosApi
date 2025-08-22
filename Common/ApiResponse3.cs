using EunigosApi.Models;
using EunigosApi.Models.CommonModels;

namespace EunigosApi.Common
{

    public class ApiResponse3
    {
        public ApiResponse3(bool success, List<Error> error, object data, MetaData meta,
            PaginationDto pagination)
        {
            Success = success;
            Error = error;
            Data = data;
            Pagination = pagination;
            // Initialize MetaData with automatic Timestamp and RequestId
            Meta = new MetaData
            {
                Pagination = meta?.Pagination,
                Timestamp = DateTime.UtcNow,         // Automatically set current timestamp
                RequestId = Guid.NewGuid().ToString() // Automatically generate a unique request ID
            };
        }

        public bool Success { get; set; }
        public List<Error> Error { get; set; }
        public object Data { get; set; }
        public MetaData Meta { get; set; }
        public PaginationDto Pagination { get; set; }  // Add this property to store pagination
    }

    public class MetaData
    {
        public PaginationDto? Pagination { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public string RequestId { get; set; } = Guid.NewGuid().ToString();
    }


}
