using DesignPatterns.Interfaces.Factory;

namespace DesignPatterns.Models.Factory
{
    public class SubtractModel : ICalculate
    {
		public SubtractModel()
		{
		}

        public double Calculate(double a, double b)
        {
            return a - b;
        }
    }
}

