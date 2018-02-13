using Expressions.Generic.Base.Compilable;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Condition
{
	public sealed class ParameterlessConditionExpression<TResult>
		: ParameterlessCompilableExpression<TResult, ParameterlessConditionExpression<TResult>>,
		IParameterlessResultExpression<TResult>
	{
		public ParameterlessConditionExpression(IParameterlessResultExpression<bool> condition,
			IParameterlessResultExpression<TResult> ifExpression,
			IParameterlessResultExpression<TResult> elseExpression)
			: base(Native.Expression.Condition(condition.GetNativeExpression(), ifExpression.GetNativeExpression(),
				elseExpression.GetNativeExpression()))
		{
		}
	}
}