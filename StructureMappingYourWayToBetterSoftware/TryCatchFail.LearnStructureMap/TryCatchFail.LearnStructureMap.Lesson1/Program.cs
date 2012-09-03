using StructureMap;
using TryCatchFail.LearnStructureMap.Lesson1.DataProviders;
using TryCatchFail.LearnStructureMap.Lesson1.Import;

namespace TryCatchFail.LearnStructureMap.Lesson1
{
	class Program
    {
        static void Main(string[] args)
        {
			using (var container = new Container(new ProgramRegistry()))
			{
				var provider = container.GetInstance<IProductDataProvider>();
				var importer = container.GetInstance<IBulkImporter>();

				importer.Import(provider.GetProducts());
			}
        }
    }
}
