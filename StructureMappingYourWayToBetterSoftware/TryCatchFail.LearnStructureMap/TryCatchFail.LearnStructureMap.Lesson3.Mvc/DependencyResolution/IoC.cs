using StructureMap;
using TryCatchFail.LearnStructureMap.Lesson3.Mvc.Services;

namespace TryCatchFail.LearnStructureMap.Lesson3.Mvc.DependencyResolution {
    public static class IoC 
	{
        public static IContainer Initialize() 
		{
            ObjectFactory.Initialize(x =>
                                     	{
                                     		x.For<IWelcomeMessageProvider>().Use<GuidWelcomeMessageProvider>();

											x.SetAllProperties(y => y.WithAnyTypeFromNamespaceContainingType<IWelcomeMessageProvider>());
                                     	});

            return ObjectFactory.Container;
        }
    }
}