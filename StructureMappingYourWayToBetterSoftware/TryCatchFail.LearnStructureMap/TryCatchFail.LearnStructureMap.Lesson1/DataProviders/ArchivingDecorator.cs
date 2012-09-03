using System;
using System.Collections.Generic;
using System.IO;

namespace TryCatchFail.LearnStructureMap.Lesson1.DataProviders
{
	public class ArchivingDecorator : IProductDataProvider, IDisposable
	{
		private readonly IProductDataProvider _target;
		private readonly ImportSettings _settings;

		public ArchivingDecorator(IProductDataProvider target, ImportSettings settings)
		{
			_target = target;
			_settings = settings;
		}

		public IEnumerable<ProductData> GetProducts()
		{
			return _target.GetProducts();
		}

		public void Dispose()
		{
			foreach (var file in Directory.EnumerateFiles(_settings.InputDirectory))
			{
				File.Move(file, Path.Combine(_settings.ArchiveDirectory, file));
			}
		}
	}
}