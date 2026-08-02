using InstagramClone.Application.Interfaces.DTO.Common;

namespace InstagramClone.Application.DTOs.Group.Requests
{
    public class WriteGroupDto : IDto
    {
        public WriteGroupDto(string name, string about)
            => (Name, About) = (name, about);

        public string Name { get; set; }
        public string About { get; set; }
    }
}