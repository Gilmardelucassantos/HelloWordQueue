using HelloWorld.Message;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Startup
    {
        private readonly IMessageService _messageService;
        
        public Startup(IMessageService messageService)
        {
            _messageService = messageService;
        }
        

        public async Task Run()
        {
            ThreadPool.QueueUserWorkItem(
                callBack => 
                _messageService.Send()
                );

            ThreadPool.QueueUserWorkItem(
                callBack =>
                _messageService.Get()
                );
        }
    }
}
