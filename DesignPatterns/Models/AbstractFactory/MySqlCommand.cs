using System;
namespace DesignPatterns.Models.AbstractFactory
{
	public class MySqlCommand : Command
	{
        private readonly Connection connection;

        public MySqlCommand(Connection connection)
		{
            this.connection = connection;
        }

        public override bool Execute(string sql)
        {
            Console.WriteLine("MySql Command Executed");

            return true;
        }
    }
}

