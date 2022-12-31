using System;
namespace DesignPatterns.Models.Prototype
{
	public abstract class FileModel
	{
		public void OpenProcessAndClose()
		{
			this.Open();

			this.Process();

			this.Close();
		}

		public abstract void Open();
		public abstract void Process();
		public abstract void Close();
	}
}

