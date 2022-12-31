using System;
namespace DesignPatterns.Models.AbstractFactory
{
	public abstract class Connection
	{
        public bool Connected { get; internal set; }

        public abstract bool Connect();
		public abstract bool ExecuteCommand(string Sql);
		public abstract bool Close();
	}
}

