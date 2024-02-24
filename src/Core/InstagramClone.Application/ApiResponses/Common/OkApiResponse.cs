namespace InstagramClone.Application.ApiResponses.Common
{
    public class OkApiResponse : ApiResponseBase
    {
        public OkApiResponse(string message = "Operation successfull") : base(true, message)
        {
        }
    }
}