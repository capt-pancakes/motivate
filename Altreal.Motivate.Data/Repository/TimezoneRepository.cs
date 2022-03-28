using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altreal.Motivate.Shared.Models;

namespace Altreal.Motivate.Data.Repository
{
    public class TimezoneRepository: Repository<Timezone, MotivateContext>
    {
        public TimezoneRepository(MotivateContext context) : base(context)
        {
        }

        public override Task<Timezone> Add(Timezone obj)
        {
            throw new NotImplementedException();
        }

        public override Task<Timezone> GetById<T>(T id)
        {
            throw new NotImplementedException();
        }

        public override Task<Timezone> Update(Timezone entity)
        {
            throw new NotImplementedException();
        }
    }
}
