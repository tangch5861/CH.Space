using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CH.Domain.Core.Events
{
    public abstract class Message : IRequest<Boolean>
    {
        public string MessageType { get; protected set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }
    }
}
