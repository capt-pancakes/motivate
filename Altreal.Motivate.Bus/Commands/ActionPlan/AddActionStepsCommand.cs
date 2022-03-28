using Altreal.Motivate.Shared.Dtos;
using Altreal.Motivate.Shared.Models;

namespace Altreal.Motivate.Bus.Commands.ActionPlan;

public class AddActionStepsCommand : ActionPlanCommand<bool>
{
    public List<ActionStepDto> Steps { get; }

    public AddActionStepsCommand(Guid actionPlanId, List<ActionStepDto> steps)
    {
        ActionPlanId = actionPlanId;
        Steps = steps;
    }
    public override bool IsValid()
    {
        return true;
    }
}