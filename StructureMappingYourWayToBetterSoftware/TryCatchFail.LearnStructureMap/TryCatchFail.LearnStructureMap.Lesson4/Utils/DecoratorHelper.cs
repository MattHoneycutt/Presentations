using System;
using StructureMap.Configuration.DSL.Expressions;
using StructureMap.Interceptors;
using StructureMap.Pipeline;

namespace TryCatchFail.LearnStructureMap.Lesson4.Utils
{
	public class DecoratorHelper<TTarget>
	{
		private readonly Action<ContextEnrichmentHandler<TTarget>> _decorateCommand;

		public DecoratorHelper(SmartInstance<TTarget> instance)
		{
			_decorateCommand = e => instance.EnrichWith(e);
		}

		public DecoratorHelper(CreatePluginFamilyExpression<TTarget> target)
		{
			ContextEnrichmentHandler<TTarget> callback = (ctx, t) => t;

			_decorateCommand = e =>
				{
					callback = e;
				};

			target.EnrichAllWith((ctx, t) => callback(ctx, t));
		}

		public DecoratedInstance<TTarget> With<TDecorator>()
		{
			ContextEnrichmentHandler<TTarget> decorator = (ctx, t) =>
			{
				//var pluginType = ctx.BuildStack.Current.RequestedType;
				var pluginType = ctx.BuildStack.Current != null
					                 ? ctx.BuildStack.Current.RequestedType
					                 : typeof (TTarget);

				ctx.RegisterDefault(pluginType, t);

				return ctx.GetInstance<TDecorator>();
			};

			_decorateCommand(decorator);

			return new DecoratedInstance<TTarget>(_decorateCommand, decorator);
		}
	}
}