using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CroweHelloWorldDomainData
{
    public class HelloWorldRepositoryFakeDb : IHelloWorldRepository
    {
        private List<string> fakeBackendDB = new List<string>();

        /// <summary>
        /// Save a string value to a backend storage container
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task SaveMessageAsync(string message)
        {
            fakeBackendDB.Add(message);
            await Task.Delay(1);  // simulate some fake delay
        }
    }
}
