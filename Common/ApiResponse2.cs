using EunigosApi.Models;

namespace EunigosApi.Common
{
    public class ApiResponse2
    {

        public ApiResponse2(bool success, List<Error> message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public List<Error> Message { get; set; }
        public object Data { get; set; }
    }

    

   
}
