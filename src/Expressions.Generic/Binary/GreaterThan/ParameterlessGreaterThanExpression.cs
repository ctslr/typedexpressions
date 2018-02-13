using Expressions.Generic.Base.Binary;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Binary.GreaterThan
{
	public sealed class ParameterlessGreaterThanExpression<T> : ParameterlessBinaryExpression<T, bool>,
		IParameterlessResultExpression<bool>
	{
		public ParameterlessGreaterThanExpression(IParameterlessResultExpression<T> constant1,
			IParameterlessResultExpression<T> constant2)
			: base(Native.BinaryExpression.GreaterThan, constant1, constant2)
		{
		}
	}
}