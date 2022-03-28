namespace Altreal.Motivate.Shared.Models
{
    public class JournalEntry : BaseEntity
    {
        public Guid UserId { get; set; }
        public string Description { get; set; }
        public virtual List<JournalBehavior> Behaviors { get; set; }
    }
}