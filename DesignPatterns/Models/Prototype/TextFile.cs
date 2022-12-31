using System;
namespace DesignPatterns.Models.Prototype
{
	public class TextFile : FileModel
	{
		public TextFile()
		{
		}

        public override void Close()
        {
            Console.WriteLine("Text file has been closed");
        }

        public override void Open()
        {
            Console.WriteLine("Text file has been opened");
        }

        public override void Process()
        {
            Console.WriteLine("Text file has been processed");
        }
    }
}

