using Expressions.Generic.Parameter;

namespace Expressions.Generic
{
    public static partial class Expression
    {
		public static ParameterExpression<T> Parameter<T>()
			=> new ParameterExpression<T>();
	}
}