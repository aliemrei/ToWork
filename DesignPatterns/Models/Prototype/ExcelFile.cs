using System;
namespace DesignPatterns.Models.Prototype
{
	public class ExcelFile : FileModel
	{
		public ExcelFile()
		{
		}

        public override void Close()
        {
            Console.WriteLine("Excel file has been closed");
        }

        public override void Open()
        {
            Console.WriteLine("Excel file has been opened");
        }

        public override void Process()
        {
            Console.WriteLine("Excel file has been processed");

        }
    }
}

