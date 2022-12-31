using System;
namespace DesignPatterns.Models.AbstractFactory
{
	public class Factory
	{
        private readonly DatabaseFactory databaseFactory;
        private readonly Connection databaseConnection;
        private readonly Command databaseCommand;

        public Factory(DatabaseFactory databaseFactory)
		{
            this.databaseFactory = databaseFactory;

            this.databaseConnection = databaseFactory.CreateConnection();

            this.databaseCommand = databaseFactory.CreateCommand(this.databaseConnection);
        }

        public void ExecuteSql(string sql)
        {
            this.databaseConnection.Connect();

            if (!this.databaseConnection.Connected)
                Console.WriteLine(this.databaseConnection.ToString() + " is not connected");
            else
            {
                this.databaseCommand.Execute(sql);

                Console.WriteLine(this.databaseConnection.ToString() + " has executed a sql");

                this.databaseConnection.Close();
            }
        }
	}
}

