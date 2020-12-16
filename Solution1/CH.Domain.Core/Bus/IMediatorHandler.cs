using CH.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CH.Domain.Core.Bus
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T Command) where T : Command;


    }
}
