using InstagramClone.Domain.Entities.Common.Base;

namespace InstagramClone.Domain.Entities
{
    public class Thought : ModifiableEntityBase
    {
        public Thought(string text)
            => Text = text;


        public Thought(Guid id, string text) : base(id)
            => Text = text;

        public string Text { get; set; }
    }
}