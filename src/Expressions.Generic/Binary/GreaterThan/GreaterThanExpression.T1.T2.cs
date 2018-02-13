using Expressions.Generic.Base.Binary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Binary.GreaterThan
{
	public sealed class GreaterThanExpression<T1, T2, TResult> : BinaryExpression<T1, T2, TResult, bool>,
		IResultExpression<(T1, T2), bool>
	{
		public GreaterThanExpression(IResultExpression<T1, TResult> left, IResultExpression<T2, TResult> right)
			: base(Native.BinaryExpression.GreaterThan, left, right)
		{
		}
	}
}