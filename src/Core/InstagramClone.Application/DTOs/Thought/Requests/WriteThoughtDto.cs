using InstagramClone.Application.Interfaces.DTO.Common;

namespace InstagramClone.Application.DTOs.Thought.Requests
{
    public class WriteThoughtDto : IDto
    {
        public WriteThoughtDto(string text)
            => (Text) = (text);

        public string Text { get; set; }
    }
}