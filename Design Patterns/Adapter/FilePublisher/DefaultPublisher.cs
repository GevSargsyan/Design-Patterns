using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.FilePublisher
{
    public class DefaultPublisher : IFilePublisher
    {
        public void Publish(IEnumerable<string> content)
        {
            Console.WriteLine($"Publishing the content of {nameof(content)}...");

            foreach (var item in content)
            {
                Console.WriteLine(item);
            }
        }
    }
}
