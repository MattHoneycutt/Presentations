using TryCatchFail.LearnStructureMap.Lesson2.Domain;

namespace TryCatchFail.LearnStructureMap.Lesson2.Repositories
{
	public class InMemoryProductRepository : IProductRepository
	{
		public Product Find(int id)
		{
			return new Product {ID = id};
		}
	}
}