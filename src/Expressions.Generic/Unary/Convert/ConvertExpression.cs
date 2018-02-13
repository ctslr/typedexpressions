using Expressions.Generic.Base.Unary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Unary.Convert
{
	public sealed class ConvertExpression<TPrevious, TCurrent, TResult> : UnaryExpression<TPrevious, TCurrent, TResult>,
		IResultExpression<TPrevious, TResult>
	{
		public ConvertExpression(IResultExpression<TPrevious, TCurrent> innerExpression)
			: base(q => Native.Expression.Convert(q, typeof(TResult)), innerExpression)
		{
		}
	}
}