using InstagramClone.Application.ApiResponses.Common;
using InstagramClone.Application.Interfaces.DTO.Common;

namespace InstagramClone.Application.ApiResponses
{
    public class DataApiResponse<T> : OkApiResponse
        where T : class, IDto
    {
        public DataApiResponse(T data, string message = "Operation successfull") : base(message)
            => (Data) = (data);

        public T Data { get; set; }
    }
}