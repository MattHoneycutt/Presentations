using StructureMap.Configuration.DSL;

namespace TryCatchFail.LearnStructureMap.Lesson1.InjectableConfig
{
	public class InjectableSettingsRegistry : Registry
	{
		public InjectableSettingsRegistry()
		{
			Scan(scan =>
			     	{
						//TODO: You can restrict this to only a subset of available assemblies in a variety of ways...
			     		scan.AssembliesFromApplicationBaseDirectory();
			     		scan.Convention<AppSettingsScanner>();
			     	});
		}
	}
}