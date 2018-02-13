using Expressions.Generic.Base.Unary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Unary.Not
{
	public sealed class NotExpression<T, TResult> : UnaryExpression<T, TResult, TResult>, IResultExpression<T, TResult>
	{
		public NotExpression(IResultExpression<T, TResult> innerExpression)
			: base(Native.Expression.Not, innerExpression)
		{
		}
	}
}