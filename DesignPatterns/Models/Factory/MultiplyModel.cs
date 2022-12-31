using System;
using DesignPatterns.Interfaces.Factory;

namespace DesignPatterns.Models.Factory
{
	public class MultiplyModel : ICalculate
    {
		public MultiplyModel()
		{
		}

        public double Calculate(double a, double b)
        {
            return a * b;
        }
    }
}

