using Altreal.Motivate.Shared.Models;

namespace Altreal.Motivate.Bus.Commands.ActionPlan;

public class AddEditActionPlanBehaviorsCommand : ActionPlanCommand<bool>
{
    public Dictionary<Guid, Emphasis> Behaviors { get; }

    public AddEditActionPlanBehaviorsCommand(Guid actionPlanId, Dictionary<Guid, Emphasis> behaviors)
    {
        ActionPlanId = actionPlanId;
        Behaviors = behaviors;
    }
    public override bool IsValid()
    {
        return true;
    }
}