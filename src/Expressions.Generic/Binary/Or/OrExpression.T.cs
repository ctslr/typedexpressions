using Expressions.Generic.Base.Binary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Binary.Or
{
	public sealed class OrExpression<T, TResult> : BinaryExpression<T, TResult, TResult>, IResultExpression<T, TResult>
	{
		public OrExpression(IParameterlessResultExpression<TResult> constant, IResultExpression<T, TResult> parameter)
			: base(Native.BinaryExpression.Or, constant, parameter)
		{
		}

		public OrExpression(IResultExpression<T, TResult> parameter, IParameterlessResultExpression<TResult> constant)
			: base(Native.BinaryExpression.Or, parameter, constant)
		{
		}
	}
}
