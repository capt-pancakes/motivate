namespace Altreal.Motivate.Bus.Commands.ActionPlan;

public class RemoveActionPlanBehaviorCommand : ActionPlanCommand<bool>
{
    public List<Guid> Behaviors { get; }

    public RemoveActionPlanBehaviorCommand(Guid actionPlanId, List<Guid> behaviors)
    {
        Behaviors = behaviors;
        ActionPlanId = actionPlanId;
    }
    public override bool IsValid()
    {
        return true;
    }
}