using Expressions.Generic.Base.Binary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Binary.And
{
	public sealed class AndExpression<T, TResult> : BinaryExpression<T, TResult, TResult>,
		IResultExpression<T, TResult>
	{
		public AndExpression(IResultExpression<T, TResult> inner, IParameterlessResultExpression<TResult> constant)
			: base(Native.BinaryExpression.And, inner, constant)
		{
		}

		public AndExpression(IParameterlessResultExpression<TResult> constant, IResultExpression<T, TResult> inner)
			: base(Native.BinaryExpression.And, constant, inner)
		{
		}
	}
}