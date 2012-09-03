using TryCatchFail.LearnStructureMap.Lesson2.Domain;

namespace TryCatchFail.LearnStructureMap.Lesson2.Calculators
{
	public interface ITaxCalculator
	{
		decimal CalculateTax(Product product);
	}
}