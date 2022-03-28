namespace Altreal.Motivate.Shared.Models
{
    public class JournalBehavior : BaseEntity
    {
        public virtual JournalEntry JournalEntry { get; set; }
        public virtual Behavior Behavior { get; set; }
    }
}