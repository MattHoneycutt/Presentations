using TryCatchFail.LearnStructureMap.Lesson2.Domain;

namespace TryCatchFail.LearnStructureMap.Lesson2.Calculators
{
	public class TaxCalculator : ITaxCalculator
	{
		private readonly ISimpleCalculator _calc;

		public TaxCalculator(ISimpleCalculator calc)
		{
			_calc = calc;
		}

		public decimal CalculateTax(Product product)
		{
			return (decimal) _calc.Multiply(1.1, product.ID);
		}
	}
}