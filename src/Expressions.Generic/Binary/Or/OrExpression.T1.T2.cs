using Expressions.Generic.Base.Binary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Binary.Or
{
	public sealed class OrExpression<T1, T2, TResult> : BinaryExpression<T1, T2, TResult, TResult>,
		IResultExpression<(T1, T2), TResult>
	{
		public OrExpression(IResultExpression<T1, TResult> left, IResultExpression<T2, TResult> right)
			: base(Native.BinaryExpression.Or, left, right)
		{
		}
	}
}