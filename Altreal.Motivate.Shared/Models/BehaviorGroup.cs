namespace Altreal.Motivate.Shared.Models
{
    public class BehaviorGroup : BaseEntity
    {
        public string NameKey { get; set; }
        public int Order { get; set; }
        public virtual List<Behavior> Behaviors { get; set; }
    }
}