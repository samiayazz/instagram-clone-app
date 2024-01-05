﻿namespace InstagramClone.API.Models.Responses.Common
{
    public abstract class ApiResponseBase
    {
        protected ApiResponseBase(bool isSuccess, string message)
            => (IsSuccess, Message) = (isSuccess, message);

        public bool IsSuccess { get; set; }
        public string Message { get; set; }
    }
}