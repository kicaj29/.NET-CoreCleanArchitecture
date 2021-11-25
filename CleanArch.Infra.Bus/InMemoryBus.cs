using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Bus
{
    public class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public Task SendCommandAsync<T>(T command) where T : Command
        {
            return this._mediator.Send(command);
        }
    }
}
