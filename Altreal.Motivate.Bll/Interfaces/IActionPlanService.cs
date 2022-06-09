using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altreal.Motivate.Shared.Dtos;
using Altreal.Motivate.Shared.Models;

namespace Altreal.Motivate.Bll.Interfaces
{
    public interface IActionPlanService
    {
        public Task<bool> CreateActionPlan(ActionPlan actionPlan);
        public Task DeleteActionPlan(Guid id);
        public Task UpdateActionPlan(ActionPlan actionPlan);
        public Task ValidateActionPlan(Guid id);
        public Task CompleteActionPlan(ActionPlan actionPlan);
        public Task ShareActionPlan(Guid id);
        public Task<bool> AddEditBehaviors(Guid actionPlanId, Dictionary<Guid, Emphasis> behaviors);
        public Task<bool> RemoveBehaviors(Guid actionPlanId, List<Guid> behaviors);
        public Task<bool> AddUpdateActionSteps(Guid actionPlanId, List<ActionStepDto> steps);
        public Task<bool> RemoveActionSteps(Guid actionPlanId, List<Guid> steps);
    }
}
