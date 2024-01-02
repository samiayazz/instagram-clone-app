using InstagramClone.Domain.Entities.Common.Base;

namespace InstagramClone.Domain.Entities
{
    public class Thought : ModifiableEntityBase
    {
        public Thought(Guid id, Guid createdById, string text) : base(id, createdById)
            => Text = text;

        public string Text { get; set; }
    }
}