using System.Collections.Generic;

namespace TryCatchFail.LearnStructureMap.Lesson1.DataProviders
{
	public class DescriptionTrimmerDecorator : IProductDataProvider
	{
		private readonly IProductDataProvider _target;

		public DescriptionTrimmerDecorator(IProductDataProvider target)
		{
			_target = target;
		}

		public IEnumerable<ProductData> GetProducts()
		{
			foreach (var product in _target.GetProducts())
			{
				if (product.Description.Length > 255)
				{
					product.Description = product.Description.Substring(0, 255);
				}

				yield return product;
			}
		}
	}
}