using System.Collections.Generic;

namespace TryCatchFail.LearnStructureMap.Lesson1.Import
{
	public interface IBulkImporter
	{
		void Import(IEnumerable<ProductData> products);
	}
}