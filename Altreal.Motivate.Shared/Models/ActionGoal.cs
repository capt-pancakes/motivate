namespace Altreal.Motivate.Shared.Models
{
    public class ActionGoal : BaseEntity
    {
        public virtual ActionPlan ActionPlan { get; set; }
        public virtual OrganizationGoal OrganizationGoal { get; set; }
        public string Answer { get; set; }
        public int Sort { get; set; }
        public GoalType CustomType { get; set; }
    }
}
