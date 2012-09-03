using StructureMap.Configuration.DSL;
using TryCatchFail.LearnStructureMap.Lesson1.DataProviders;
using TryCatchFail.LearnStructureMap.Lesson1.Utils;

namespace TryCatchFail.LearnStructureMap.Lesson1
{
	public class ProgramRegistry : Registry
	{
		public ProgramRegistry()
		{
			Scan(scan =>
			     	{
			     		scan.TheCallingAssembly();
			     		scan.WithDefaultConventions();
			     		scan.LookForRegistries();
			     	});

			For<IProductDataProvider>().Use<ProductDataProvider>()
				.Decorate().With<ValidPriceDecorator>()
				.AndThen<DescriptionTrimmerDecorator>()
				.AndThen<ArchivingDecorator>();
		}
	}
}