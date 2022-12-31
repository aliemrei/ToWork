using System;
namespace DesignPatterns.Models.AbstractFactory
{
    public class SqlCommand : Command
    {
        private readonly Connection connection;

        public SqlCommand( Connection connection)
        {
            this.connection = connection;
        }

        public override bool Execute(string sql)
        {
            Console.WriteLine("Command executed");

            return true;
        }
    }
}

