using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorldAPI
{
    public class HelloWorldAPIv1 : IHelloWorldAPI
    {
        /// <summary>
        /// Method to get a message string
        /// </summary>
        /// <returns>Required string value</returns>
        public async Task<string> GetMessageAsync()
        {
            return await Task.FromResult("Hello World");
        }
    }
}
