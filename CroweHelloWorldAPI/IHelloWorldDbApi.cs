using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorldAPI
{
    public interface IHelloWorldDbApi
    {
        Task SaveMessageAsync(string message);
    }
}
