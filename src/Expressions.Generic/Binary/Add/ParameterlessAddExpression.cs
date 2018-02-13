using Expressions.Generic.Base.Binary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Binary.Add
{
	public sealed class ParameterlessAddExpression<TResult> : ParameterlessBinaryExpression<TResult, TResult>,
		IParameterlessResultExpression<TResult>
	{
		public ParameterlessAddExpression(IParameterlessResultExpression<TResult> constant1,
			IParameterlessResultExpression<TResult> constant2)
			: base(Native.BinaryExpression.Add, constant1, constant2)
		{
		}
	}
}