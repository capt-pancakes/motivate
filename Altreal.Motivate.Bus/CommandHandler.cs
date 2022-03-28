using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altreal.Motivate.Bll.Interfaces;
using Altreal.Motivate.Bus.Commands.ActionPlan;
using Altreal.Motivate.Shared.Models;
using MediatR;

namespace Altreal.Motivate.Bus
{
    public class CommandHandler :
        IRequestHandler<CreateActionPlanCommand, ActionPlan>,
        IRequestHandler<AddEditActionPlanBehaviorsCommand, bool>,
        IRequestHandler<RemoveActionPlanBehaviorCommand, bool>,
        IRequestHandler<AddActionStepsCommand, bool>,
        IRequestHandler<RemoveActionStepsCommand, bool>
    {
        private readonly IActionPlanService _actionPlanService;

        public CommandHandler(IActionPlanService actionPlanService)
        {
            _actionPlanService = actionPlanService;
        }
        public Task<ActionPlan> Handle(CreateActionPlanCommand request, CancellationToken cancellationToken)
        {
            return _actionPlanService.CreateActionPlan(request.ActionPlan);
        }

        public Task<bool> Handle(AddEditActionPlanBehaviorsCommand request, CancellationToken cancellationToken)
        {
            return _actionPlanService.AddEditBehaviors(request.ActionPlanId, request.Behaviors);
        }

        public Task<bool> Handle(RemoveActionPlanBehaviorCommand request, CancellationToken cancellationToken)
        {
            return _actionPlanService.RemoveBehaviors(request.ActionPlanId, request.Behaviors);
        }

        public Task<bool> Handle(AddActionStepsCommand request, CancellationToken cancellationToken)
        {
            return _actionPlanService.AddUpdateActionSteps(request.ActionPlanId, request.Steps);
        }

        public Task<bool> Handle(RemoveActionStepsCommand request, CancellationToken cancellationToken)
        {
            return _actionPlanService.RemoveActionSteps(request.ActionPlanId, request.Steps);
        }
    }
}
