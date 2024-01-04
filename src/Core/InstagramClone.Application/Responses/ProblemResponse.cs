using InstagramClone.Application.Responses.Common;

namespace InstagramClone.Application.Responses
{
    public class ProblemResponse : ResponseBase
    {
        public ProblemResponse(string code, ICollection<string>? details = null,
            string message = "An unexpected error occurred while processing the request")
            : base(false, message)
            => (Code, Details) = (code, details);

        // Todo: Add an ErrorCode Enum here
        public string Code { get; set; }
        public ICollection<string>? Details { get; set; }
    }
}