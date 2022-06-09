using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altreal.Motivate.Bll.Interfaces;
using Altreal.Motivate.Data.Repository;
using Altreal.Motivate.Data.Seeders;
using Altreal.Motivate.Shared.Dtos;
using Altreal.Motivate.Shared.Models;

namespace Altreal.Motivate.Bll.Services
{
    public class ActionPlanService: IActionPlanService
    {
        private readonly IRepository<ActionPlan> _repo;

        public ActionPlanService(IRepository<ActionPlan> repo)
        {
            _repo = repo;
        }
        public async Task<bool> CreateActionPlan(ActionPlan actionPlan)
        {
            var resp = await _repo.Add(actionPlan);
            return (await _repo.SaveChangesAsync()) > 0;
        }

        public Task DeleteActionPlan(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateActionPlan(ActionPlan actionPlan)
        {
            throw new NotImplementedException();
        }

        public Task ValidateActionPlan(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task CompleteActionPlan(ActionPlan actionPlan)
        {
            throw new NotImplementedException();
        }

        public Task ShareActionPlan(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AddEditBehaviors(Guid actionPlanId, Dictionary<Guid, Emphasis> behaviors)
        {
            var plan = await _repo.GetById(actionPlanId);
            foreach (var (behavior, emphasis) in behaviors)
            {
                var planBehavior =  plan.Behaviors?.FirstOrDefault(b => b.BehaviorId == behavior);
                if (planBehavior != null)
                {
                    planBehavior.Emphasis = emphasis;
                    planBehavior.UpdatedAt = DateTime.UtcNow;
                    planBehavior.UpdatedBy = AdminUserSeed.Id;
                }
                else
                {
                    var apb = new ActionPlanBehavior
                    {
                        BehaviorId = behavior,
                        Emphasis = emphasis,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = AdminUserSeed.Id
                    };
                    if (plan.Behaviors != null)
                    {
                        plan.Behaviors.Add(apb);
                    }
                    else
                    {
                        plan.Behaviors = new List<ActionPlanBehavior>{apb};
                    }
                }
            }

            return await _repo.SaveChangesAsync() != -1;
        }

        public async Task<bool> RemoveBehaviors(Guid actionPlanId, List<Guid> behaviors)
        {
            var plan = await _repo.GetById(actionPlanId);
            if (plan?.Behaviors != null)
            {
                foreach (var apb in behaviors
                             .Select(behavior => plan.Behaviors?.FirstOrDefault(b => b.BehaviorId == behavior))
                             .Where(apb => apb != null))
                {
                    plan.Behaviors?.Remove(apb);
                }
            }

            return await _repo.SaveChangesAsync() != -1;
        }

        public async Task<bool> AddUpdateActionSteps(Guid actionPlanId, List<ActionStepDto> steps)
        {
            var plan = await _repo.GetById(actionPlanId);
            foreach (var step in steps)
            {
                // There should only be a single hit here // if there are more we need to address
                var t = plan.Behaviors?.Select(b => b.ActionSteps.FirstOrDefault(ba => ba.Id == step.ActionStep.Id)).SingleOrDefault();

                if (t != null)
                {
                    t.CompletedAt = step.CompletedAt ?? t.CompletedAt;
                    t.DueAt = step.DueAt ?? t.DueAt;
                    t.IsCalendarized = step.IsCalendarized ?? t.IsCalendarized;
                    t.UpdatedAt = DateTime.UtcNow;
                    t.UpdatedBy = AdminUserSeed.Id;
                }
                else
                {
                    var apBehavior = plan.Behaviors.SingleOrDefault(b => b.BehaviorId == step.ActionStep.BehaviorId);
                    apBehavior?.ActionSteps.Add(new ActionPlanActionStep
                    {
                        ActionStep = step.ActionStep,
                        CompletedAt = step.CompletedAt,
                        DueAt = step.DueAt,
                        IsCalendarized = step.IsCalendarized ?? false,
                        CreatedAt = DateTime.UtcNow,
                        CreatedBy = AdminUserSeed.Id
                    });
                }
            }
            return await _repo.SaveChangesAsync() != -1;
        }

        public async Task<bool> RemoveActionSteps(Guid actionPlanId, List<Guid> steps)
        {
            var plan = await _repo.GetById(actionPlanId);
            var stepsToRemove = plan.ActionSteps?.Where(actionSteps => steps.Contains(actionSteps.ActionStep.Id));
            if (stepsToRemove == null)
            {
                foreach (var step in stepsToRemove)
                {
                    step.DeletedAt = DateTime.UtcNow;
                    step.DeletedBy = AdminUserSeed.Id;
                }
            }
            return await _repo.SaveChangesAsync() != -1;
        }
    }
}
