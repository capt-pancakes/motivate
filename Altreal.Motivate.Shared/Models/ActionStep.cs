namespace Altreal.Motivate.Shared.Models
{
    public class ActionStep : BaseEntity
    {
        public string NameKey { get; set; }
        public string DescriptionKey { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid BehaviorId { get; set; }
        public Emphasis Emphasis { get; set; }
    }
}