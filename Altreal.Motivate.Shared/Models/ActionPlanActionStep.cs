namespace Altreal.Motivate.Shared.Models
{
    public class ActionPlanActionStep : BaseEntity
    {
        public virtual ActionStep ActionStep { get; set; }
        public virtual ActionPlan ActionPlan { get; set; }
        public virtual ActionPlanBehavior ActionPlanBehavior { get; set; }
        public DateTime? DueAt { get; set; }
        public DateTime? CompletedAt { get; set; }
        public bool IsCalendarized { get; set; }

    }
}