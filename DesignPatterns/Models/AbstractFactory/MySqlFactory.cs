using System;
namespace DesignPatterns.Models.AbstractFactory
{
	public class MySqlFactory : DatabaseFactory
    {
		public MySqlFactory()
		{
		}

        public override Command CreateCommand(Connection connection)
        {
            return new MySqlCommand(connection);
        }

        public override Connection CreateConnection()
        {
            return new MySqlConnection();
        }
    }
}

