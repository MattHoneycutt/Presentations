using System;
using System.Security;
using TryCatchFail.LearnStructureMap.Lesson4.Domain;
using TryCatchFail.LearnStructureMap.Lesson4.Services;

namespace TryCatchFail.LearnStructureMap.Lesson4.Repositories
{
	public class InMemoryProductRepository : IProductRepository
	{
		public Product Find(int id)
		{
			return new Product { ID = id };
		}
	}
}