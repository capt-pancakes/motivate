using Altreal.Motivate.Shared.Models;

namespace Altreal.Motivate.Bus.Commands.ActionPlan;

public class RemoveActionStepsCommand : ActionPlanCommand<bool>
{
    public List<Guid> Steps { get; }

    public RemoveActionStepsCommand(Guid actionPlanId, List<Guid> steps)
    {
        ActionPlanId = actionPlanId;
        Steps = steps;
    }
    public override bool IsValid()
    {
        return true;
    }
}