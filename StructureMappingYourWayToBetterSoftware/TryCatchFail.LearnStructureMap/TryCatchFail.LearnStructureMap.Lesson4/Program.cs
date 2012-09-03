using System;
using StructureMap;
using TryCatchFail.LearnStructureMap.Lesson4.Domain;
using TryCatchFail.LearnStructureMap.Lesson4.Repositories;
using TryCatchFail.LearnStructureMap.Lesson4.Services;
using System.Linq;
using TryCatchFail.LearnStructureMap.Lesson4.Utils;

namespace TryCatchFail.LearnStructureMap.Lesson4
{
	class Program
	{
		static void Main(string[] args)
		{
			User currentUser = GetCurrentUser();

			var container = new Container(cfg =>
			                              	{
			                              		cfg.For<User>().Use(currentUser);
			                              		cfg.For<IProductRepository>().Use<InMemoryProductRepository>()
			                              			.Decorate().With<ProductSecurityDecorator>()
			                              			.AndThen<ProductRepoLogger>()
													.AndThen<RudeProductRepoLogger>();
			                              		cfg.For<IProductAuthorizer>().Use<ProductAuthorizer>();
			                              	});

			var repo = container.GetInstance<IProductRepository>();

			var product = repo.Find(1);

			Console.WriteLine(product);
		}

		private static User GetCurrentUser()
		{
			return new User {UserName = "Admin"};
		}
	}
}
