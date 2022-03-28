using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altreal.Motivate.Bus.Commands
{
    public interface ICommandHandler<T>
    {
        Task<bool> Handle(T request, CancellationToken cancellationToken);
    }
}
