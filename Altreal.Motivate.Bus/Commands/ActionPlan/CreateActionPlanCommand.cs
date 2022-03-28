namespace Altreal.Motivate.Bus.Commands.ActionPlan
{
    public class CreateActionPlanCommand : ActionPlanCommand<Shared.Models.ActionPlan>
    {
        public bool IsFocus { get; }
        public Shared.Models.ActionPlan ActionPlan { get; }

        public CreateActionPlanCommand(Shared.Models.ActionPlan actionPlan, bool isFocus = false)
        {
            ActionPlan = actionPlan;
            IsFocus = isFocus;
            this.ActionPlanId = this.ActionPlan.Id;
        }
        public override bool IsValid()
        {
            return true;
        }
    }
}
