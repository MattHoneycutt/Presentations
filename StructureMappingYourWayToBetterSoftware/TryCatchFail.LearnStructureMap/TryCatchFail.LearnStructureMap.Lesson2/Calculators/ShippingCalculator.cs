using TryCatchFail.LearnStructureMap.Lesson2.Domain;

namespace TryCatchFail.LearnStructureMap.Lesson2.Calculators
{
	public class ShippingCalculator : IShippingCalculator
	{
		private readonly ISimpleCalculator _calculator;

		public ShippingCalculator(ISimpleCalculator calculator)
		{
			_calculator = calculator;
		}

		public decimal CalculateRate(Product product)
		{
			return (decimal) _calculator.Multiply(9.99, product.ID);
		}
	}
}