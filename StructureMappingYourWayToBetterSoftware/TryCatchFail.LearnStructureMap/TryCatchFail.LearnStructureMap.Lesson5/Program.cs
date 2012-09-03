using StructureMap;
using TryCatchFail.LearnStructureMap.Lesson5.InjectableConfig;
using TryCatchFail.LearnStructureMap.Lesson5.Services;

namespace TryCatchFail.LearnStructureMap.Lesson5
{
	class Program
	{
		static void Main(string[] args)
		{
			ObjectFactory.Initialize(cfg =>
			                         	{
											cfg.AddRegistry<InjectableSettingsRegistry>();
			                         		cfg.For<IFileDownloader>().Use<FtpFileDownloader>();
			                         	});

			var downloader = ObjectFactory.GetInstance<IFileDownloader>();
			downloader.Run();
		}
	}
}
