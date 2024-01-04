namespace InstagramClone.Application.Responses.Common
{
    public abstract class OkResponseBase : ResponseBase
    {
        protected OkResponseBase(string message = "Operation successfull") : base(true, message)
        {
        }
    }
}