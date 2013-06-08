using System;
using StructureMap.Interceptors;

namespace TryCatchFail.LearnStructureMap.Lesson4.Utils
{
	public class DecoratedInstance<TTarget>
	{
		private readonly Action<ContextEnrichmentHandler<TTarget>> _decorateCommand;
		private ContextEnrichmentHandler<TTarget> _decorator;

		public DecoratedInstance(Action<ContextEnrichmentHandler<TTarget>> decorateCommand, ContextEnrichmentHandler<TTarget> decorator)
		{
			_decorateCommand = decorateCommand;
			_decorator = decorator;
		}

		public DecoratedInstance<TTarget> AndThen<TDecorator>()
		{
			//Must be captured as a local variable, otherwise the closure's decorator will
			//always be the outer-most decorator, causing a Stack Overflow.
			var previousDecorator = _decorator;

			ContextEnrichmentHandler<TTarget> newDecorator = (ctx, t) =>
			{
				var pluginType = ctx.BuildStack.Current != null
						                ? ctx.BuildStack.Current.RequestedType
						                : typeof (TTarget);

				var innerInstance = previousDecorator(ctx, t);

				ctx.RegisterDefault(pluginType, innerInstance);

				return ctx.GetInstance<TDecorator>();
			};

			_decorateCommand(newDecorator);

			_decorator = newDecorator;

			return this;
		}
	}
}