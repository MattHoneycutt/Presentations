using System;
using StructureMap.Configuration.DSL;
using StructureMap.Graph;

namespace TryCatchFail.LearnStructureMap.Lesson1.InjectableConfig
{
	public class AppSettingsScanner : IRegistrationConvention
	{
		private static readonly Type InterfaceType = typeof (IAppSettings);

		public void Process(Type type, Registry registry)
		{
			if (!InterfaceType.IsAssignableFrom(type) ||
			    type.IsInterface ||
			    type.IsAbstract)
			{
				return;
			}

			registry.For(type).Singleton().Use(ctx => ctx.GetInstance<AppSettingsFactory>().GetSettingsFor(type));
		}
	}
}