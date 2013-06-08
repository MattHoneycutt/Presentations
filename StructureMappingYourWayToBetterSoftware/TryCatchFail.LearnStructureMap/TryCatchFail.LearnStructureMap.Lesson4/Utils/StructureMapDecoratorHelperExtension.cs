using StructureMap.Configuration.DSL.Expressions;
using StructureMap.Pipeline;

namespace TryCatchFail.LearnStructureMap.Lesson4.Utils
{
	public static class StructureMapExtensions
	{
		public static DecoratorHelper<TTarget> Decorate<TTarget>(this SmartInstance<TTarget> instance)
		{
			return new DecoratorHelper<TTarget>(instance);
		}

		public static DecoratorHelper<TTarget> Decorate<TTarget>(this CreatePluginFamilyExpression<TTarget> target)
		{
			return new DecoratorHelper<TTarget>(target);
		}
	}
}