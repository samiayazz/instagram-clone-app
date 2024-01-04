namespace InstagramClone.Application.Responses.Common
{
    public abstract class ResponseBase
    {
        protected ResponseBase(bool status, string message)
            => (Status, Message) = (status, message);

        public bool Status { get; set; }
        public string Message { get; set; }
    }
}