namespace InstagramClone.API.Models.Responses.Common
{
    public class ProblemApiResponse : ApiResponseBase
    {
        public ProblemApiResponse(string errorCode, ICollection<string>? details = null,
            string message = "An unexpected error occurred while processing the request")
            : base(false, message)
            => (ErrorCode, Details) = (errorCode, details);

        // Todo: Add an ErrorCode Enum here
        public string ErrorCode { get; set; }
        public ICollection<string>? Details { get; set; }
    }
}