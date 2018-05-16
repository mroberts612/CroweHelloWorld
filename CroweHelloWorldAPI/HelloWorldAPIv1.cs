using CroweHelloWorldDomainData;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorldAPI
{
    public class HelloWorldAPIv1 : IHelloWorldAPI, IHelloWorldDbApi
    {
        private readonly IHelloWorldRepository repository;

        public HelloWorldAPIv1(IHelloWorldRepository helloWorldRepository)
        {
            repository = helloWorldRepository;
        }

        /// <summary>
        /// Method to return a message string
        /// </summary>
        /// <returns>Required string value</returns>
        public async Task<string> GetMessageAsync()
        {
            return await Task.FromResult("Hello World");
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
