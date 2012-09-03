using System.Collections.Generic;

namespace TryCatchFail.LearnStructureMap.Lesson1.DataProviders
{
	public interface IProductDataProvider
	{
		IEnumerable<ProductData> GetProducts();
	}
}