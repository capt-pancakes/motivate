namespace Altreal.Motivate.Bus.Commands.ActionPlan
{
    public abstract class ActionPlanCommand<T>: Command<T>
    {
        public Guid ActionPlanId { get; protected set; }
    }
}
