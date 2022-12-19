using Adapter.Adapter;
using Adapter.FilePublisher;
using Adapter.FileWriter;
using System;
using System.Collections.Generic;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileWriter = new TextFileWriter("sample.txt");

            var sampleClass = new SampleClassUsingIFileWriterInterface(fileWriter);
            sampleClass.Run(3);

            Console.WriteLine();
            Console.WriteLine("****************************");
            Console.WriteLine();


            var filePublisher = new DefaultPublisher();
            var publisherAdapter = new PublisherToWriterAdapter(filePublisher);

            Console.WriteLine($"is filePublisher is IFileWriter ? -  {filePublisher is IFileWriter }");
            Console.WriteLine($"is publisherAdapter is IFileWriter ? -  {publisherAdapter is IFileWriter }");
            Console.WriteLine();

            var sampleClassUsingAdapter = new SampleClassUsingIFileWriterInterface(publisherAdapter);
            sampleClassUsingAdapter.Run(3);

            Console.ReadKey();
        }
    }


    public class SampleClassUsingIFileWriterInterface
    {
        private IFileWriter _fileWriter;

        public SampleClassUsingIFileWriterInterface(IFileWriter fileWriter)
        {
            _fileWriter = fileWriter;
        }

        public void Run(int iterationsCount)
        {
            var data = GenerateData(iterationsCount);
            var result = _fileWriter.Write(data);
            Console.Write("Operation Succeded: ");
            Console.WriteLine(result ? "Yes." : "No.");
        }

        private IEnumerable<string> GenerateData(int iterationsCount)
        {
            var data = new List<string>();

            for (int i = 0; i < iterationsCount; i++)
            {
                data.Add(Guid.NewGuid().ToString());
            }
            return data;
        }
    }
}
