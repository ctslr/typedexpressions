using Expressions.Generic.Base.Binary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Binary.Multiply
{
	public sealed class MultiplyExpression<T, TResult> : BinaryExpression<T, TResult, TResult>,
		IResultExpression<T, TResult>
	{
		public MultiplyExpression(IResultExpression<T, TResult> inner,
			IParameterlessResultExpression<TResult> constant)
			: base(Native.BinaryExpression.Multiply, inner, constant)
		{
		}

		public MultiplyExpression(IParameterlessResultExpression<TResult> constant,
			IResultExpression<T, TResult> inner)
			: base(Native.BinaryExpression.Multiply, constant, inner)
		{
		}
	}
}