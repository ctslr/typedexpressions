using Expressions.Generic.Base.Binary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Binary.Add
{
	public sealed class AddExpression<T1, T2, TResult> : BinaryExpression<T1, T2, TResult, TResult>,
		IResultExpression<(T1, T2), TResult>
	{
		public AddExpression(IResultExpression<T1, TResult> left, IResultExpression<T2, TResult> right)
			: base(Native.BinaryExpression.Add, left, right)
		{
		}
	}
}
