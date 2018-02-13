using Expressions.Generic.Base.Binary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Binary.GreaterThan
{
	public sealed class GreaterThanExpression<T, TResult> : BinaryExpression<T, TResult, bool>,
		IResultExpression<T, bool>
	{
		public GreaterThanExpression(IResultExpression<T, TResult> inner,
			IParameterlessResultExpression<TResult> constant)
			: base(Native.BinaryExpression.GreaterThan, inner, constant)
		{
		}

		public GreaterThanExpression(IParameterlessResultExpression<TResult> constant,
			IResultExpression<T, TResult> inner)
			: base(Native.BinaryExpression.GreaterThan, constant, inner)
		{
		}
	}
}