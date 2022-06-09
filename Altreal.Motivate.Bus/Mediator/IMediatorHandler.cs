using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altreal.Motivate.Bus.Commands;
using Altreal.Motivate.Bus.Events;
using Altreal.Motivate.Bus.Queries;

namespace Altreal.Motivate.Bus.Mediator
{
    public interface IMediatorHandler
    {
        //Task<Y> SendCommand<T, Y>(T command) where T : Command<Y>;
        Task<bool> SendCommand<T>(T command) where T : Command<bool>;
        Task RaiseEvent<T>(T @event) where T : Event;
        Task<Y> SendQuery<T, Y>(T Query) where T : Query<Y>;
    }
}
