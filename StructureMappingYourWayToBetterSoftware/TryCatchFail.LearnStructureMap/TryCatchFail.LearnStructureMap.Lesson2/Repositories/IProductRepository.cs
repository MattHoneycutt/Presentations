using TryCatchFail.LearnStructureMap.Lesson2.Domain;

namespace TryCatchFail.LearnStructureMap.Lesson2.Repositories
{
	public interface IProductRepository
	{
		Product Find(int id);
	}
}