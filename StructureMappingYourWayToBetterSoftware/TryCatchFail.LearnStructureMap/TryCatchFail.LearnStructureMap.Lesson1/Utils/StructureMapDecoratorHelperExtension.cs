using StructureMap.Pipeline;

namespace TryCatchFail.LearnStructureMap.Lesson1.Utils
{
	public static class StructureMapDecoratorHelperExtension
	{
		public static DecoratorHelper<TTarget> Decorate<TTarget>(this SmartInstance<TTarget> instance)
		{
			return new DecoratorHelper<TTarget>(instance);
		}
	}
}