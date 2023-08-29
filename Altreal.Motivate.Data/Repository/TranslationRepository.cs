using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altreal.Motivate.Shared.Models;

namespace Altreal.Motivate.Data.Repository
{
    public class TranslationRepository : Repository<Translation, MotivateContext>
    {
        private readonly MotivateContext _context;

        public TranslationRepository(MotivateContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<Translation> Add(Translation obj)
        {
            var culture = await _context.Cultures.FindAsync(new Guid("B773EFE0-0B3C-4BF7-95D6-3009D069E14F"));
            obj.Culture = culture;
            var result = _context.Translations.Add(obj);
            var saveresp = await _context.SaveChangesAsync();
            return result.Entity;
            //return Task.FromResult<Translation>(result.Entity);
        }

        public override Task<Translation?> GetById<T>(T id)
        {
            throw new NotImplementedException();
        }

        public override Task<Translation> Update(Translation entity)
        {
            throw new NotImplementedException();
        }
    }
}
