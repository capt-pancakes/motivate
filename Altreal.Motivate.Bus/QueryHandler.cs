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
        IRequestHandler<GetActionPlanQuery, ActionPlan>
    {
        private readonly IRepository<ActionPlan> _actionPlanRepo;

        public QueryHandler(IRepository<ActionPlan> actionPlanRepo)
        {
            _actionPlanRepo = actionPlanRepo;
        }
        public Task<ActionPlan> Handle(GetActionPlanQuery request, CancellationToken cancellationToken)
        {
            return _actionPlanRepo.GetById(request.ActionPlanId);
        }
    }
}
