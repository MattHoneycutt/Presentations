using System;
using TryCatchFail.LearnStructureMap.Lesson5.InjectableConfig;

namespace TryCatchFail.LearnStructureMap.Lesson5.Services
{
	public class FtpFileDownloader : IFileDownloader
	{
		private readonly FtpFileDownloaderSettings _settings;

		public class FtpFileDownloaderSettings : IAppSettings
		{
			public string Server { get; set; }
			public int Port { get; set; }
			public string UserName { get; set; }
			public string Password { get; set; }
			public string[] FileNames { get; set; }
		}

		public FtpFileDownloader(FtpFileDownloaderSettings settings)
		{
			_settings = settings;
		}

		public void Run()
		{
			Console.WriteLine("Connecting to {0}:{1}...", _settings.Server, _settings.Port);
			Console.WriteLine("User: {0}", _settings.UserName);
			Console.WriteLine("Pass: {0}", _settings.Password);
			Console.WriteLine("Downloading {0} files...", _settings.FileNames.Length);

			foreach (var fileName in _settings.FileNames)
			{
				Console.WriteLine("\t{0}...", fileName);
			}
		}
	}
}