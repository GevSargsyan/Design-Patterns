using Adapter.FilePublisher;
using Adapter.FileWriter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Adapter
{
    public class PublisherToWriterAdapter : IFileWriter
    {
        private IFilePublisher _filePublisher;

        public PublisherToWriterAdapter(IFilePublisher filePublisher)
        {
            _filePublisher = filePublisher;
        }

        public bool Write(IEnumerable<string> content)
        {
            try
            {
                Console.WriteLine($"Calling Method {nameof(Write)} of {nameof(PublisherToWriterAdapter)}");
                _filePublisher.Publish(content);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
    }
}
