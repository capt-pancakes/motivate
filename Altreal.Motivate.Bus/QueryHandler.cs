using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altreal.Motivate.Bus.Queries;
using Altreal.Motivate.Bus.Queries.ActionPlan;
using Altreal.Motivate.Data.Repository;
using Altreal.Motivate.Shared.Models;
using MediatR;

namespace Altreal.Motivate.Bus
{
    public class QueryHandler:
        IRequestHandler<GetActionPlanQuery, ActionPlan>,
        IRequestHandler<GetActionStepsQuery, List<ActionStep>>
    {
        private readonly IRepository<ActionPlan> _actionPlanRepo;
        private readonly IRepository<ActionStep> _actionStepRepo;

        public QueryHandler(
            IRepository<ActionPlan> actionPlanRepo,
            IRepository<ActionStep> actionStepRepo)
        {
            _actionPlanRepo = actionPlanRepo;
            _actionStepRepo = actionStepRepo;
        }
        public Task<ActionPlan> Handle(GetActionPlanQuery request, CancellationToken cancellationToken)
        {
            return _actionPlanRepo.GetById(request.ActionPlanId);
        }

        public async Task<List<ActionStep>> Handle(GetActionStepsQuery request, CancellationToken cancellationToken)
        {
            return (await _actionStepRepo.GetAll()).ToList();
        }
    }
}
