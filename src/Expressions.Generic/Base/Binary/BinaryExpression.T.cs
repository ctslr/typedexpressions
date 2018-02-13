using System;
using Expressions.Generic.Base.Compilable;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Base.Binary
{
	public abstract class BinaryExpression<TPrevious, TCurrent, TResult>
		: BaseExpression<BinaryExpression<TPrevious, TCurrent, TResult>>
	{
		private readonly SingleParameterCompilableContainer<TPrevious, TResult> _container;

		internal BinaryExpression(
			Func<Native.Expression, Native.Expression, Native.BinaryExpression> nativeExpression,
			IResultExpression<TPrevious, TCurrent> left,
			IParameterlessResultExpression<TCurrent> right)
			: base(nativeExpression(left.GetNativeExpression(), right.GetNativeExpression()))
		{
			_container = new SingleParameterCompilableContainer<TPrevious, TResult>(left.GetParameter());
		}

		internal BinaryExpression(
			Func<Native.Expression, Native.Expression, Native.BinaryExpression> nativeExpression,
			IParameterlessResultExpression<TCurrent> left,
			IResultExpression<TPrevious, TCurrent> right)
			: base(nativeExpression(left.GetNativeExpression(), right.GetNativeExpression()))
		{
			_container = new SingleParameterCompilableContainer<TPrevious, TResult>(right.GetParameter());
		}

		public IParameterExpression<TPrevious> GetParameter()
			=> _container.GetParameter();

		public Func<TPrevious, TResult> Compile()
			=> _container.Compile(GetNativeExpression());
	}
}