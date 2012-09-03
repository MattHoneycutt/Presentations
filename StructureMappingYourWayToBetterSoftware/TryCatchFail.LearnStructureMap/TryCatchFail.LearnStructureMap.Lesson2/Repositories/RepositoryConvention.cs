using System;
using System.Linq;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace TryCatchFail.LearnStructureMap.Lesson2.Repositories
{
	internal class RepositoryConvention : IRegistrationConvention
	{
		public void Process(Type type, Registry registry)
		{
			if (!type.IsInterface && 
			    !type.IsAbstract &&
			    type.Name.EndsWith("Repository"))
			{
				var interfaceType = type.GetInterfaces().Single(i => i.Name.EndsWith("Repository"));

				registry.For(interfaceType).Use(type);
			}
		}
	}
}