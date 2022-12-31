using System;
namespace DesignPatterns.Models.AbstractFactory
{
	public abstract class Command
	{
		public abstract bool Execute(string sql);
	}
}

