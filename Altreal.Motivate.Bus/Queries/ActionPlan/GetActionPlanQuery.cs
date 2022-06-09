using Altreal.Motivate.Shared.Models;

namespace Altreal.Motivate.Bus.Queries.ActionPlan
{
    public class GetActionPlanQuery : Query<Shared.Models.ActionPlan>
    {
        public Guid ActionPlanId { get; }
        public GetActionPlanQuery(Guid actionPlanId)
        {
            this.ActionPlanId = actionPlanId;
        }
    }

    public class GetActionStepsQuery : Query<List<ActionStep>>
    {
        public Guid ActionPlanId { get; }

        public GetActionStepsQuery(Guid actionPlanId)
        {
            ActionPlanId = actionPlanId;
        }
    }
}
