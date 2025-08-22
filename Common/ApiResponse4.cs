using EunigosApi.Models;

namespace EunigosApi.Common
{

    public class ApiResponse4<T>
    {

        public ApiResponse4(List<Error> error, T? data, T? meta)
        {
            Errors = error;
            Data = data;
            Meta = meta;
        }

        public List<Error> Errors { get; set; }
        public T? Data { get; set; }

        public T? Meta { get; set; }
    }

}
