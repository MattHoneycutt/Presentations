using TryCatchFail.LearnStructureMap.Lesson1.InjectableConfig;

namespace TryCatchFail.LearnStructureMap.Lesson1
{
	public class ImportSettings : IAppSettings
	{
		public string InputDirectory { get; set; }

		public string ConnectionString { get; set; }

		public int BatchSize { get; set; }

		public string ArchiveDirectory { get; set; }
	}
}