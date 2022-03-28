using Altreal.Motivate.Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Altreal.Motivate.Shared.Models;

namespace Altreal.Monitvate.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimezoneController : ControllerBase
    {
        private readonly IRepository<Timezone> _repo;

        public TimezoneController(IRepository<Timezone> repo)
        {
            _repo = repo;
        }

        //[HttpGet]
        //public async Task<Timezone> Get(Guid id)
        //{
        //    return await _repo.GetById(id);
        //}

        [HttpGet]
        public async Task<IActionResult> Get(Guid? id)
        {
            if (id != null)
            {
                return Ok(await _repo.GetById(id));
            }
            return Ok(await _repo.GetAll());
        }

        [HttpPost]
        public async Task<Timezone> Post(Timezone tz)
        {
            return await _repo.Add(tz);
        }

        [HttpDelete]
        public void Delete(Guid id)
        {
            _repo.Remove(id);
        }

        [HttpPatch]
        public async Task<Timezone> Put(Timezone tz)
        {
            return await _repo.Update(tz);
        }


    }
}