using System;
namespace DesignPatterns.Models.AbstractFactory
{
	public abstract class DatabaseFactory
	{
		public abstract Connection CreateConnection();
		public abstract Command CreateCommand(Connection connection);
	}
}

