using InstagramClone.API.Models.Responses.Common;
using InstagramClone.Application.Interfaces.DTO.Common;

namespace InstagramClone.API.Models.Responses
{
    public class DataApiResponse<T> : OkApiResponse
        where T : class, IDto
    {
        public DataApiResponse(T data, string message = "Operation successfull") : base(message)
            => (Data) = (data);

        public T Data { get; set; }
    }
}