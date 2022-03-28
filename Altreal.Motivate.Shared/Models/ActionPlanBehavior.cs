using System.ComponentModel.DataAnnotations.Schema;

namespace Altreal.Motivate.Shared.Models
{
    public class ActionPlanBehavior : BaseEntity
    {
        [ForeignKey("ActionPlanId")]
        public virtual ActionPlan ActionPlan { get; set; }
        public Guid BehaviorId { get; set; }
        public Emphasis Emphasis { get; set; }
        public virtual List<ActionPlanActionStep> ActionSteps { get; set; }
    }
}