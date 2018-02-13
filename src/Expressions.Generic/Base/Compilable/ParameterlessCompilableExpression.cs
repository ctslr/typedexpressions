using System;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Base.Compilable
{
	public abstract class ParameterlessCompilableExpression<TResult, TFullType> : BaseExpression<TFullType>
	{
		public ParameterlessCompilableExpression(Native.Expression expression) : base(expression)
		{
		}

		public Func<TResult> Compile()
		{
			var lambda = Native.Expression.Lambda<Func<TResult>>(GetNativeExpression());
			return lambda.Compile();
		}
	}
}
