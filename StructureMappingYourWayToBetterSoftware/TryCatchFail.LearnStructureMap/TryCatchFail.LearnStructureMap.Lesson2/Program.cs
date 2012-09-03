using System;
using StructureMap;
using TryCatchFail.LearnStructureMap.Lesson2.Calculators;
using TryCatchFail.LearnStructureMap.Lesson2.Infrastructure;
using TryCatchFail.LearnStructureMap.Lesson2.Repositories;

namespace TryCatchFail.LearnStructureMap.Lesson2
{
	class Program 
	{
		static void Main(string[] args)
		{
			var container = new Container(cfg =>
			                              	{
			                              		cfg.AddRegistry<CalculatorRegistry>();
												cfg.AddRegistry<RepositoryRegistry>();

												cfg.For<ILogger>().Use<Logger>();
											});

			var productRepository = container.GetInstance<IProductRepository>();
			var product = productRepository.Find(1);

			var taxCalculator = container.GetInstance<ITaxCalculator>();
			Console.WriteLine("Tax is: {0:C}", taxCalculator.CalculateTax(product));

			container.Configure(cfg =>
			                    	{
			                    		cfg.For<ILogger>().Use<NullLogger>();
			                    	});

			var shippingCalculator = container.GetInstance<IShippingCalculator>();
			Console.WriteLine("Shipping is: {0:C}", shippingCalculator.CalculateRate(product));

			Console.WriteLine("Are they equal? " + container.GetInstance<IShippingCalculator>().Equals(container.GetInstance<IShippingCalculator>()));
		}
	}
}
