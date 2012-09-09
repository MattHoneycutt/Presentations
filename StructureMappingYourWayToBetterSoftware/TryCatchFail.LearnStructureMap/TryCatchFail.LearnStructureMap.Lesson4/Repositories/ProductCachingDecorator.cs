using System.Collections.Concurrent;
using TryCatchFail.LearnStructureMap.Lesson4.Domain;

namespace TryCatchFail.LearnStructureMap.Lesson4.Repositories
{
	public class ProductCachingDecorator : IProductRepository
	{
		private readonly IProductRepository _innerRepo;
		private readonly ConcurrentDictionary<int, Product> _cache;

		public ProductCachingDecorator(IProductRepository innerRepo)
		{
			_innerRepo = innerRepo;
			_cache = new ConcurrentDictionary<int, Product>();
		}

		public Product Find(int id)
		{
			return _cache.GetOrAdd(id, _ => _innerRepo.Find(id));
		}
	}
}