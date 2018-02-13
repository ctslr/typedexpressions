using Expressions.Generic.Base.Unary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Unary.Increment
{
	public sealed class IncrementExpression<T, TResult> : UnaryExpression<T, TResult, TResult>,
		IResultExpression<T, TResult>
	{
		public IncrementExpression(IResultExpression<T, TResult> innerExpression)
			: base(Native.Expression.Increment, innerExpression)
		{
		}
	}
}