using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.FileWriter
{
    internal class TextFileWriter : IFileWriter
    {
        public string Path { get; set; }
        public TextFileWriter(string path)
        {
            Path = path;
        }
        public bool Write(IEnumerable<string> content)
        {
            try
            {
                Console.WriteLine($"Calling method {nameof(Write)} of {nameof(TextFileWriter)}");
                File.WriteAllLines(Path, content);
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
