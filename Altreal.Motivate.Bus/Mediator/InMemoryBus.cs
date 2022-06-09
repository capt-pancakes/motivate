using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altreal.Motivate.Bus.Commands;
using Altreal.Motivate.Bus.Events;
using Altreal.Motivate.Bus.Queries;
using MediatR;

namespace Altreal.Motivate.Bus.Mediator
{
    public class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;
        //private readonly INotificationStore _notificationStore;
        //private readonly IEventStore _eventStore;

        public InMemoryBus(
            IMediator mediator
            //, IEventStore eventStore,
            //INotificationStore notificationStore
            )
        {
            _mediator = mediator;
            //_eventStore = eventStore;
            //_notificationStore = notificationStore;
        }

        //public Task<Y> SendCommand<T, Y>(T command) where T : Command<Y>
        //{
        //    return _mediator.Send<Y>(command);
        //}

        //public Task SendCommand<T>(T command) where T : Command
        //{
        //    return _mediator.Send<bool>(command);
        //}

        public Task<bool> SendCommand<T>(T command) where T : Command<bool>
        {
            return _mediator.Send<bool>(command);
        }

        public Task RaiseEvent<T>(T @event) where T : Event
        {
            if (!@event.MessageType.Equals("DomainNotification"))
            {
                //_eventStore?.Save(@event);
            }
            else
            {
                //_notificationStore.Save(@event);
            }

            return _mediator.Publish(@event);
        }

        public Task<Y> SendQuery<T, Y>(T query) where T : Query<Y>
        {
            return _mediator.Send(query);
        }
    }
}
