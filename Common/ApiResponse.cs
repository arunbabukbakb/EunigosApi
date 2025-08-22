using EunigosApi.Models;

namespace EunigosApi.Common
{
    public class ApiResponse<T>
    {

        public ApiResponse(bool success, List<Error> message, T? data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public List<Error> Message { get; set; }
        public T? Data { get; set; }

        public MetaData Meta { get; set; }
    }

    
}
