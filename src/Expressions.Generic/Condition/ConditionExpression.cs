using System;
using Expressions.Generic.Base;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Condition
{
	public sealed class ConditionExpression<TConditionParameter, TResult>
		: BaseExpression<ConditionExpression<TConditionParameter, TResult>>,
		IResultExpression<TConditionParameter, TResult>
	{
		private readonly IParameterExpression<TConditionParameter> _parameter;

		public ConditionExpression(IResultExpression<TConditionParameter, bool> condition,
			IParameterlessResultExpression<TResult> ifExpression,
			IParameterlessResultExpression<TResult> elseExpression)
			: base(Native.Expression.Condition(condition.GetNativeExpression(), ifExpression.GetNativeExpression(),
				elseExpression.GetNativeExpression()))
		{
			_parameter = condition.GetParameter();
		}

		public Func<TConditionParameter, TResult> Compile()
		{
			var parameters = _parameter.GetNativeParameters();
			var actualLambda = Native.Expression.Lambda(GetNativeExpression(), parameters);
			var func = actualLambda.Compile();
			if (!_parameter.IsCompound)
			{
				return (Func<TConditionParameter, TResult>)func;
			}

			Native.Expression<Func<TConditionParameter, TResult>> wrapper = q
				=> (TResult)func.DynamicInvoke(_parameter.ExtractValues(q));

			return wrapper.Compile();
		}

		public IParameterExpression<TConditionParameter> GetParameter()
			=> _parameter;
	}
}