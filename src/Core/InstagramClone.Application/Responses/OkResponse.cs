using InstagramClone.Application.Interfaces.DTO.Common;
using InstagramClone.Application.Responses.Common;

namespace InstagramClone.Application.Responses
{
    public abstract class OkResponse<T> : OkResponseBase
        where T : class, IDto
    {
        protected OkResponse(T data, string message = "Operation successfull") : base(message)
            => (Data) = (data);

        public T Data { get; set; }
    }
}