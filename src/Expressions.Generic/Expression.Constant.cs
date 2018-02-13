using Expressions.Generic.Constant;

namespace Expressions.Generic
{
	public static partial class Expression
    {
		public static ConstantExpression<T> Constant<T>(T value)
			=> new ConstantExpression<T>(value);
	}
}