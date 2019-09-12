using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Message
{
    public interface IMessageService
    {
        Task Send();
        Task Get();
    }
}
