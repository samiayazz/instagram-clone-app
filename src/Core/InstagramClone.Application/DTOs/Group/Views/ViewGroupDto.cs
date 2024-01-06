using InstagramClone.Application.DTOs.Identity.Views;
using InstagramClone.Application.Interfaces.DTO.Common;

namespace InstagramClone.Application.DTOs.Group.Views
{
    public class ViewGroupDto : IDto
    {
        public ViewGroupDto(Guid id, string name, string about, Guid createdById, ViewUserDto createdBy,
            DateTime createdDate, Guid? updatedById = null, ViewUserDto? updatedBy = null, DateTime? updatedDate = null)
            => (Id, Name, About, CreatedById, CreatedBy, CreatedDate,
                    UpdatedById, UpdatedBy, UpdatedDate) =
                (id, name, about, createdById, createdBy, createdDate,
                    updatedById, updatedBy, updatedDate);

        public Guid Id { get; set; }

        public string Name { get; set; }
        public string About { get; set; }

        public Guid CreatedById { get; set; }
        public ViewUserDto CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public Guid? UpdatedById { get; set; }
        public ViewUserDto? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}