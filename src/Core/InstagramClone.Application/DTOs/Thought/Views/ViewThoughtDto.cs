using InstagramClone.Application.DTOs.Identity.Views;
using InstagramClone.Application.Interfaces.DTO.Common;

namespace InstagramClone.Application.DTOs.Thought.Views
{
    public class ViewThoughtDto : IDto
    {
        public ViewThoughtDto(Guid id, string text, Guid createdById, ViewUserDto createdBy, DateTime createdDate,
            Guid? updatedById = null, ViewUserDto? updatedBy = null, DateTime? updatedDate = null)
            => (Id, Text, CreatedById, CreatedBy, CreatedDate,
                    UpdatedById, UpdatedBy, UpdatedDate) =
                (id, text, createdById, createdBy, createdDate,
                    updatedById, updatedBy, updatedDate);

        public Guid Id { get; set; }

        public string Text { get; set; }

        public Guid CreatedById { get; set; }
        public ViewUserDto CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public Guid? UpdatedById { get; set; }
        public ViewUserDto? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}