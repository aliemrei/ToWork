using System;
namespace DesignPatterns.Models.AbstractFactory
{
	public class MySqlConnection : Connection
	{
		public MySqlConnection()
		{
		}

        public override bool Close()
        {
            this.Connected = false;

            Console.WriteLine("MySqlConnection closed");

            return true;
        }

        public override bool Connect()
        {
            this.Connected = true;

            Console.WriteLine("MySqlConnection opened");

            return true;
        }

        public override bool ExecuteCommand(string Sql)
        {
            Console.WriteLine("MySqlCommand executed");

            return true;
        }
    }
}

