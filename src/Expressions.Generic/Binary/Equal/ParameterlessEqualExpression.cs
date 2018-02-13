using Expressions.Generic.Base.Binary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Binary.Equal
{
	public sealed class ParameterlessEqualExpression<T> : ParameterlessBinaryExpression<T, bool>,
		IParameterlessResultExpression<bool>
	{
		public ParameterlessEqualExpression(IParameterlessResultExpression<T> constant1,
			IParameterlessResultExpression<T> constant2)
			: base(Native.BinaryExpression.Equal, constant1, constant2)
		{
		}
	}
}