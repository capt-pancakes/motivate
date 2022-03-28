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
}
