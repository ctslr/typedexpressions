using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Constant
{
	public sealed class ConstantExpression<T> : IParameterlessResultExpression<T>
	{
		private readonly T _value;

		internal ConstantExpression(T value)
		{
			_value = value;
		}

		public Native.Expression GetNativeExpression()
			=> Native.Expression.Constant(_value);
	}
}