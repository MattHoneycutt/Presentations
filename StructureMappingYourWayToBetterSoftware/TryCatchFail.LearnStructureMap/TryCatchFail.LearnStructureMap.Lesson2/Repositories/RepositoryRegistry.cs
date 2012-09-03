using StructureMap.Configuration.DSL;

namespace TryCatchFail.LearnStructureMap.Lesson2.Repositories
{
	internal class RepositoryRegistry : Registry
	{
		public RepositoryRegistry()
		{
			Scan(scan =>
			     	{
			     		scan.TheCallingAssembly();
						scan.With(new RepositoryConvention());
			     	});
		}
	}
}