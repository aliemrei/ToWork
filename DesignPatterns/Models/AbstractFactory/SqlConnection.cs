using System;
namespace DesignPatterns.Models.AbstractFactory
{
	public class SqlConnection : Connection
	{
		public SqlConnection()
		{
		}

        public override bool Close()
        {
            this.Connected = false;

            Console.WriteLine("SqlConnection closed");

            return true;
        }

        public override bool Connect()
        {
            this.Connected = true;

            Console.WriteLine("SqlConnection opened");

            return true;
        }

        public override bool ExecuteCommand(string Sql)
        {
            Console.WriteLine("SqlCommand executed");

            return true;
        }
    }
}

