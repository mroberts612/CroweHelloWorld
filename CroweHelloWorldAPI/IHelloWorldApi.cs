using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorldAPI
{
    public interface IHelloWorldAPI: IHelloWorldDbApi
    {
        Task<string> GetMessageAsync();
    }
}
