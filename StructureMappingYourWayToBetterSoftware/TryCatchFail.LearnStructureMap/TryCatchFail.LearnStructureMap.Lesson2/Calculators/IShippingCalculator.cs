using TryCatchFail.LearnStructureMap.Lesson2.Domain;

namespace TryCatchFail.LearnStructureMap.Lesson2.Calculators
{
	public interface IShippingCalculator
	{
		decimal CalculateRate(Product product);
	}
}