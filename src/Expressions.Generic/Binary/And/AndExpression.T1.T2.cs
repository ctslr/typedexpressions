using Expressions.Generic.Base.Binary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Binary.And
{
	public sealed class AndExpression<T1, T2, TResult> : BinaryExpression<T1, T2, TResult, TResult>,
		IResultExpression<(T1, T2), TResult>
	{
		public AndExpression(IResultExpression<T1, TResult> left, IResultExpression<T2, TResult> right)
			: base(Native.BinaryExpression.And, left, right)
		{
		}
	}
}