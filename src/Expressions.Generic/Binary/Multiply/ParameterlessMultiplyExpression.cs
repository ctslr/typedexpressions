using Expressions.Generic.Base.Binary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Binary.Multiply
{
	public sealed class ParameterlessMultiplyExpression<TResult> : ParameterlessBinaryExpression<TResult, TResult>,
		IParameterlessResultExpression<TResult>
	{
		public ParameterlessMultiplyExpression(IParameterlessResultExpression<TResult> constant1,
			IParameterlessResultExpression<TResult> constant2)
			: base(Native.BinaryExpression.Multiply, constant1, constant2)
		{
		}
	}
}