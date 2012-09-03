using TryCatchFail.LearnStructureMap.Lesson4.Domain;

namespace TryCatchFail.LearnStructureMap.Lesson4.Repositories
{
	public interface IProductRepository
	{
		Product Find(int id);
	}
}