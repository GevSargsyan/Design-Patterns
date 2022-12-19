using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.FilePublisher
{
    public interface IFilePublisher
    {
        void Publish(IEnumerable<string> content);
    }
}
