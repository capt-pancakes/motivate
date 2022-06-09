using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altreal.Motivate.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Altreal.Motivate.Data.Repository
{
    public class ActionStepRepository : Repository<ActionStep, MotivateContext>
    {
        private readonly MotivateContext _context;

        public ActionStepRepository(MotivateContext context) : base(context)
        {
            _context = context;
        }

        public override Task<ActionStep> Add(ActionStep obj)
        {
            throw new NotImplementedException();
        }

        public override Task<ActionStep> GetById<T>(T id)
        {
            var stepId = (Guid)(object)id!;
            return _context.ActionSteps.FirstOrDefaultAsync(step => step.Id == stepId);
        }

        public override Task<ActionStep> Update(ActionStep entity)
        {
            throw new NotImplementedException();
        }
    }
    public class ActionPlanRepository : Repository<ActionPlan, MotivateContext>
    {
        private readonly MotivateContext _ctx;

        public ActionPlanRepository(MotivateContext ctx) : base(ctx)
        {
            _ctx = ctx;
            _ctx.ActionPlans.Include(ap => ap.Behaviors);
        }

        //public override Task<ActionPlan> GetById<T>(T id)
        //{
        //    throw new NotImplementedException();
        //}

        public override async Task<ActionPlan> GetById<T>(T id)
        {
            var apId = (Guid)(object)id!;
            return (await _ctx.ActionPlans.Include(ap => ap.Behaviors).FirstOrDefaultAsync(ap => ap.Id == apId))!;
        }

        //public Task<ActionPlan> GetById(Guid id)
        //{
        //    return _ctx.ActionPlans.Include(ap => ap.Behaviors).FirstOrDefaultAsync(ap => ap.Id == id);
        //}

        public override Task<ActionPlan> Add(ActionPlan obj)
        {
            obj.CreatedAt = DateTime.UtcNow;
            var resp = _ctx.ActionPlans.Add(obj);
            return Task.FromResult(resp.Entity);
        }

        public override async Task<ActionPlan> Update(ActionPlan obj)
        {
            obj.UpdatedAt = DateTime.UtcNow;
            _ctx.ActionPlans.Update(obj);
            await base.SaveChangesAsync();
            return obj;
        }
    }
}
