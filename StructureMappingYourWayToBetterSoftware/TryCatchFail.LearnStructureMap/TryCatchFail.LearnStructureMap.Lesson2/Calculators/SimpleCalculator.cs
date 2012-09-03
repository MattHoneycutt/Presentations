using System;
using TryCatchFail.LearnStructureMap.Lesson2.Infrastructure;

namespace TryCatchFail.LearnStructureMap.Lesson2.Calculators
{
	public class SimpleCalculator : ISimpleCalculator
	{
		private readonly ILogger _logger;

		public SimpleCalculator(ILogger logger)
		{
			_logger = logger;
		}

		public int Add(int x, int y)
		{
			var sum = x + y;

			_logger.WriteLine("Adding {0}, {1}: {2}", x, y, sum);

			return sum;
		}

		public double Multiply(double x, double y)
		{
			var product = x*y;

			_logger.WriteLine("Multiplying {0}, {1}: {2}", x, y, product);

			return product;
		}
	}
}