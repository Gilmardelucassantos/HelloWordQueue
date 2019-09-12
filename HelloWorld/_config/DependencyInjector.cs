using HelloWorld.App;
using HelloWorld.Message;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWorld._config
{
    public static class DependencyInjector
    {
        public static void AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<Startup>();

            services.AddSingleton<IAppProvider>(provider =>
              new AppProvider(configuration["AppId"]));

            services.AddScoped<IMessageService, MessageService>();
        }
    }
}
