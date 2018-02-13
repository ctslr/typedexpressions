using Expressions.Generic.Base.Binary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Binary.And
{
	public sealed class ParameterlessAndExpression<TResult> : ParameterlessBinaryExpression<TResult, TResult>,
		IParameterlessResultExpression<TResult>
	{
		public ParameterlessAndExpression(IParameterlessResultExpression<TResult> constant1,
			IParameterlessResultExpression<TResult> constant2)
			: base(Native.BinaryExpression.And, constant1, constant2)
		{
		}
	}
}