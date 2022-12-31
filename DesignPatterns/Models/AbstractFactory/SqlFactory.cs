using System;
namespace DesignPatterns.Models.AbstractFactory
{
	public class SqlFactory : DatabaseFactory
	{
        public override Command CreateCommand(Connection connection)
        {
            return new SqlCommand(connection);
        }

        public override Connection CreateConnection()
        {
            return new SqlConnection(); 
        }
    }
}

