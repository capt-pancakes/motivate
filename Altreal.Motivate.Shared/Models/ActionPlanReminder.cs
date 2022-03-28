namespace Altreal.Motivate.Shared.Models
{
    public class ActionPlanReminder : BaseEntity
    {
        public virtual ActionPlan ActionPlan { get; set; }
        public Frequency Frequency { get; set; }
        public ReminderType Type { get; set; }
        public Guid? ActionStepId { get; set; }
        public bool IsCalendarized { get; set; }
        public DateTime? StartsAt { get; set; }
    }
}