using System;
using DesignPatterns.Interfaces.Factory;

namespace DesignPatterns.Models.Factory
{
	public class DivideModel : ICalculate
	{
		public DivideModel()
		{
		}

        public double Calculate(double a, double b)
        {
            return a / b;
        }
    }
}

