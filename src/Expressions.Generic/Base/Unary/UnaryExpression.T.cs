using System;
using Expressions.Generic.Base.Compilable;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Base.Unary
{
	public abstract class UnaryExpression<TPrevious, TCurrent, TResult>
		: BaseExpression<UnaryExpression<TPrevious, TCurrent, TResult>>
	{
		private readonly SingleParameterCompilableContainer<TPrevious, TResult> _container;

		internal UnaryExpression(
			Func<Native.Expression, Native.UnaryExpression> nativeExpression,
			IResultExpression<TPrevious, TCurrent> inner) : base(nativeExpression(inner.GetNativeExpression()))
		{
			_container = new SingleParameterCompilableContainer<TPrevious, TResult>(inner.GetParameter());
		}

		public IParameterExpression<TPrevious> GetParameter()
			=> _container.GetParameter();

		public Func<TPrevious, TResult> Compile()
			=> _container.Compile(GetNativeExpression());
	}
}