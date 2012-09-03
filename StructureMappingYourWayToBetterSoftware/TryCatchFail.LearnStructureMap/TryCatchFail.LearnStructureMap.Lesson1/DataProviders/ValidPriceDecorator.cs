using System;
using System.Collections.Generic;

namespace TryCatchFail.LearnStructureMap.Lesson1.DataProviders
{
	public class ValidPriceDecorator : IProductDataProvider
	{
		private readonly IProductDataProvider _target;

		public ValidPriceDecorator(IProductDataProvider target)
		{
			_target = target;
		}

		public IEnumerable<ProductData> GetProducts()
		{
			foreach (var product in _target.GetProducts())
			{
				if (product.Price <= 0)
				{
					Console.Error.WriteLine("Skipping {0} because it has a price less than or equal to 0.", product.ProductID);
					continue;
				}

				yield return product;
			}
		}
	}
}