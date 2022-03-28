using Altreal.Motivate.Data.Repository;
using Altreal.Motivate.Data.Seeders;
using Altreal.Motivate.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;

namespace Altreal.Monitvate.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranslationController : ControllerBase
    {
        private readonly IRepository<Translation> _repo;
        private readonly IWebHostEnvironment _env;

        public TranslationController(IRepository<Translation> repo, IWebHostEnvironment env)
        {
            _repo = repo;
            _env = env;
        }
        [HttpGet]
        public Task<Translation> Get(Guid id)
        {
            return _repo.GetById(id);
        }

        //[HttpPost]
        //public async Task<IActionResult> Create([FromBody]string name)
        //{
        //    var path = _env.ContentRootFileProvider.GetDirectoryContents("Translations\\en_US");
        //    var file = path.FirstOrDefault(p => p.Name.Contains(name));

        //    if (file == null)
        //    {
        //        return NotFound(name);
        //    }

        //    //using (var stream = file.CreateReadStream())
        //    //{
        //    //    using (var reader = new StreamReader(stream))
        //    //    {
        //    //        var results = reader.ReadToEnd();
        //    //        if (!String.IsNullOrEmpty(results))
        //    //        {
        //    //            //await _repo.Add(new Translation
        //    //            //{
        //    //            //    CreatedBy = AdminUserSeed.Id,
        //    //            //    CreatedAt = DateTime.UtcNow,
        //    //            //    Key = name,
        //    //            //    Value = results, 
        //    //            //});
        //    //            return Ok(results);
        //    //        }

        //    //        return NotFound(name);
        //    //    }
        //    //}

        //    //return _repo.Add(new Translation

        //    //{
        //    //    CreatedBy = AdminUserSeed.Id,
        //    //    CreatedAt = DateTime.UtcNow,
        //    //    Key = "action_plan",
        //    //    Value = translation,
        //    //});
        //}
    }
}
