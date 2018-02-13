using Expressions.Generic.Base.Binary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Binary.Equal
{
	public sealed class EqualExpression<T1, T2, TResult> : BinaryExpression<T1, T2, TResult, bool>,
		IResultExpression<(T1, T2), bool>
	{
		public EqualExpression(IResultExpression<T1, TResult> left, IResultExpression<T2, TResult> right)
			: base(Native.BinaryExpression.Equal, left, right)
		{
		}
	}
}
