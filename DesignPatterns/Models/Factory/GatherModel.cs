using System;
using DesignPatterns.Interfaces.Factory;

namespace DesignPatterns.Models.Factory
{
	public class GatherModel: ICalculate
	{
		public GatherModel()
		{
		}

        public double Calculate(double a, double b)
        {
            return a + b;
        }
    }
}

