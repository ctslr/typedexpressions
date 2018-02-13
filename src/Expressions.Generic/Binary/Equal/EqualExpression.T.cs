using Expressions.Generic.Base.Binary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Binary.Equal
{
	public sealed class EqualExpression<T, TResult> : BinaryExpression<T, TResult, bool>, IResultExpression<T, bool>
	{
		public EqualExpression(IResultExpression<T, TResult> inner, IParameterlessResultExpression<TResult> constant)
			: base(Native.BinaryExpression.Equal, inner, constant)
		{
		}

		public EqualExpression(IParameterlessResultExpression<TResult> constant, IResultExpression<T, TResult> inner)
			: base(Native.BinaryExpression.Equal, constant, inner)
		{
		}
	}
}