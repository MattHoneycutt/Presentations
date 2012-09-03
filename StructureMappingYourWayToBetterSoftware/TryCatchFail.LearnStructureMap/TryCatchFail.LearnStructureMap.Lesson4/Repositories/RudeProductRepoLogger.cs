using System;
using TryCatchFail.LearnStructureMap.Lesson4.Domain;

namespace TryCatchFail.LearnStructureMap.Lesson4.Repositories
{
	public class RudeProductRepoLogger : IProductRepository
	{
		private readonly IProductRepository _target;

		public RudeProductRepoLogger(IProductRepository target)
		{
			_target = target;
		}

		public Product Find(int id)
		{
			Console.WriteLine("Hey there, jerk.");

			return _target.Find(id);
		}
	}
}