using Expressions.Generic.Base.Binary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Binary.Or
{
	public sealed class ParameterlessOrExpression<TResult> : ParameterlessBinaryExpression<TResult, TResult>,
		IParameterlessResultExpression<TResult>
	{
		public ParameterlessOrExpression(IParameterlessResultExpression<TResult> constant1,
			IParameterlessResultExpression<TResult> constant2)
			: base(Native.BinaryExpression.Or, constant1, constant2)
		{
		}
	}
}