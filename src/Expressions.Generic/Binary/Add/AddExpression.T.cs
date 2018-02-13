using Expressions.Generic.Base.Binary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Binary.Add
{
	public sealed class AddExpression<T, TResult> : BinaryExpression<T, TResult, TResult>,
		IResultExpression<T, TResult>
	{
		public AddExpression(IResultExpression<T, TResult> inner, IParameterlessResultExpression<TResult> constant)
			: base(Native.BinaryExpression.Add, inner, constant)
		{
		}

		public AddExpression(IParameterlessResultExpression<TResult> constant, IResultExpression<T, TResult> inner)
			: base(Native.BinaryExpression.Add, constant, inner)
		{
		}
	}
}