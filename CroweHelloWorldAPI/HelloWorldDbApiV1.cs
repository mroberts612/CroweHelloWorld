using CroweHelloWorldDomainData;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorldAPI
{
    public class HelloWorldDbApiV1 : IHelloWorldDbApi
    {
        private readonly IHelloWorldRepository repository;

        /// <summary>
        /// Constructor for the HelloWorldDbAPI
        /// </summary>
        /// <param name="helloWorldRepository">Injected IHelloWorldRepository object</param>
        public HelloWorldDbApiV1(IHelloWorldRepository helloWorldRepository)
        {
            repository = helloWorldRepository;
        }

        /// <summary>
        /// Method to save a message to a message repository
        /// </summary>
        /// <param name="message">The message string to save</param>
        /// <returns></returns>
        public async Task SaveMessageAsync(string message)
        {
            await repository.SaveMessageAsync(message);
        }
    }
}
