using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorldDomainData
{
    public interface IHelloWorldRepository
    {
        Task SaveMessageAsync(string message);
    }
}
