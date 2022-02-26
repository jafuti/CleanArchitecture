using Clean.Arch.Domain.Core.Bus;
using Clean.Arch.Domain.Core.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Arch.Infra.Bus
{
    public sealed class InMemoryBus :IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }
        //The bus orchostrates the messages that are going back and forth

        //push the messages through the bus and then you have various connected handlers that are looking for certain types of messages.
        //in order to send the commands through the bus, it is a kind of wrapper around the mediator that send a method

        public Task SendCommand<T>(T command) where T : Command
        {
            return _mediator.Send(command);
        }

    }
}
