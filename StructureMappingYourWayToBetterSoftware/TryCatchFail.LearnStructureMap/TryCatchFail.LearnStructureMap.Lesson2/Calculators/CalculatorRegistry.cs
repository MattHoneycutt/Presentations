using StructureMap.Configuration.DSL;

namespace TryCatchFail.LearnStructureMap.Lesson2.Calculators
{
	internal class CalculatorRegistry : Registry
	{
		public CalculatorRegistry()
		{
			Scan(scan =>
			     	{
			     		scan.TheCallingAssembly();
			     		scan.WithDefaultConventions();
			     	});
		}
	}
}