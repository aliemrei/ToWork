using System;
namespace DesignPatterns.Models
{
	public class SingletonModel
	{
		private readonly static object padLock = new object();

		private static SingletonModel _instance;

		private SingletonModel()
		{
		}

		public static SingletonModel GetInstance()
		{
			if (_instance == null)
			{
				lock(padLock) //for threadsafe
				{
					_instance = new SingletonModel();
				}
			}

			return _instance;
		}
		//or
		public static SingletonModel Instance
		{
			get
			{
				return GetInstance();
			}
		}
	}
}

