using Expressions.Generic.Base.Unary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Unary.Not
{
	public sealed class ParameterlessNotExpression<T> : ParameterlessUnaryExpression<T, T>,
		IParameterlessResultExpression<T>
	{
		public ParameterlessNotExpression(IParameterlessResultExpression<T> innerExpression)
			: base(Native.Expression.Not, innerExpression)
		{
		}
	}
}