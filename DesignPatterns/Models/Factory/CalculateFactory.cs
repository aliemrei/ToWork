using System;
using DesignPatterns.Interfaces.Factory;

namespace DesignPatterns.Models.Factory
{
	public static class CalculateFactory
	{
		public static ICalculate GetCalculator(string type)
		{
			if (type.ToLower().Equals("gather"))
				return new GatherModel();
			else if (type.ToLower().Equals("divide"))
                return new DivideModel();
            else if (type.ToLower().Equals("multiply"))
                return new MultiplyModel();
            else  
                return new SubtractModel();
        }
	}
}

