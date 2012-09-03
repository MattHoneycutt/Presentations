using System;
using System.Collections.Generic;
using System.IO;

namespace TryCatchFail.LearnStructureMap.Lesson1.DataProviders
{
	public class ProductDataProvider : IProductDataProvider
	{
		private readonly ImportSettings _settings;

		public ProductDataProvider(ImportSettings settings)
		{
			_settings = settings;
		}

		public IEnumerable<ProductData> GetProducts()
		{
			foreach (var file in Directory.EnumerateFiles(_settings.InputDirectory))
			{
				using (var stream = File.OpenText(file))
				{
					while (!stream.EndOfStream)
					{
						var line = stream.ReadLine();

						var parts = line.Split(',');

						var productData = new ProductData();
						productData.ProductID = Guid.Parse(parts[0]);
						productData.Description = parts[1];
						productData.Price = decimal.Parse(parts[2]);

						yield return productData;
					}
				}
			}
		}
	}
}