using Altreal.Motivate.Bus.Commands.ActionPlan;
using Altreal.Motivate.Bus.Mediator;
using Altreal.Motivate.Bus.Queries;
using Altreal.Motivate.Bus.Queries.ActionPlan;
using Altreal.Motivate.Shared.Dtos;
using Altreal.Motivate.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Altreal.Monitvate.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionPlanController : ControllerBase
    {
        private readonly IMediatorHandler _bus;

        public ActionPlanController(IMediatorHandler bus)
        {
            _bus = bus;
        }
        [HttpGet]
        public async Task<IActionResult> Get(Guid id)
        {
           var result = await _bus.SendQuery<GetActionPlanQuery, ActionPlan>(new GetActionPlanQuery(id));
           return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ActionPlan actionPlan)
        {
            var resp = await _bus.SendCommand<CreateActionPlanCommand, ActionPlan>(new CreateActionPlanCommand(actionPlan));
            return Ok(resp);
        }

        [HttpPatch]
        [Route("{id:guid}/behaviors")]
        public async Task<IActionResult> AddBehaviors(Dictionary<Guid, Emphasis> behaviors, Guid id)
        {
            var resp = await _bus.SendCommand<AddEditActionPlanBehaviorsCommand, bool>(new AddEditActionPlanBehaviorsCommand(id, behaviors));
            return Ok();
        }

        [HttpDelete]
        [Route("{id:guid}/behaviors")]
        public async Task<IActionResult> RemoveBehaviors(List<Guid> behaviors, Guid id)
        {
            var resp = await _bus.SendCommand<RemoveActionPlanBehaviorCommand, bool>(new RemoveActionPlanBehaviorCommand(id, behaviors));
            return Ok();
        }

        [HttpPatch]
        [Route("{id:guid}/steps")]
        public async Task<IActionResult> AddActionSteps(List<ActionStepDto> steps, Guid id)
        {
            var resp = await _bus.SendCommand<AddActionStepsCommand, bool>(new AddActionStepsCommand(id, steps));
            return Ok();
        }

        [HttpDelete]
        [Route("{id:guid}/steps")]
        public async Task<IActionResult> RemoveActionSteps(List<Guid> steps, Guid id)
        {
            var resp = await _bus.SendCommand<RemoveActionStepsCommand, bool>(new RemoveActionStepsCommand(id, steps));
            return Ok();
        }
    }
}
