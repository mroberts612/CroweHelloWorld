using System;
using System.Threading.Tasks;
using CroweHelloWorldAPI;
using CroweHelloWorldDomainData;
using Microsoft.Extensions.DependencyInjection;

namespace CroweHelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            MainAsync().GetAwaiter().GetResult();
        }

        private static async Task MainAsync()
        {
            // SETUP DI services
            var services = new ServiceCollection();
            services.AddTransient<IHelloWorldAPI, HelloWorldAPIv1>();

            // include these 2 lines if database support is needed
            //services.AddTransient<IHelloWorldDbApi, HelloWorldDbApiV1>();
            services.AddTransient<IHelloWorldRepository, HelloWorldRepositoryFakeDb>();
            var provider = services.BuildServiceProvider();

            // Resolve needed services
            IHelloWorldAPI api = provider.GetService<IHelloWorldAPI>();
            // Include these 2 lines if database support is needed
            //IHelloWorldDbApi dbapi = provider.GetService<IHelloWorldDbApi>();
            IHelloWorldRepository repository = provider.GetService<IHelloWorldRepository>();

            try
            {
                Console.WriteLine(await api.GetMessageAsync());

                // include this line if database write is needed.
                await api.SaveMessageAsync(await api.GetMessageAsync());
                Console.WriteLine("Data saved to repository");
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing API methods.", ex);
            }
        }
    }
}
