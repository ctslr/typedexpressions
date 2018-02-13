using System;
using System.Linq;
using Expressions.Generic.Base;
using Expressions.Generic.Interfaces;
using Expressions.Generic.Parameter;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Condition
{
	public sealed class ConditionExpression<TConditionParameter, TParameter1, TParameter2, TResult>
		: BaseExpression<ConditionExpression<TConditionParameter, TParameter1, TParameter2, TResult>>,
		IResultExpression<(TConditionParameter, (TParameter1, TParameter2)), TResult>
	{
		private readonly IParameterExpression<TConditionParameter> _conditionParameter;
		private readonly IParameterExpression<TParameter1> _parameter1;
		private readonly IParameterExpression<TParameter2> _parameter2;

		public ConditionExpression(IResultExpression<TConditionParameter, bool> condition,
			IResultExpression<TParameter1, TResult> ifExpression,
			IResultExpression<TParameter2, TResult> elseExpression)
			: base(Native.Expression.Condition(condition.GetNativeExpression(), ifExpression.GetNativeExpression(),
				elseExpression.GetNativeExpression()))
		{
			_conditionParameter = condition.GetParameter();
			_parameter1 = ifExpression.GetParameter();
			_parameter2 = elseExpression.GetParameter();
		}

		public Func<TConditionParameter, TParameter1, TParameter2, TResult> Compile()
		{
			var parameters = _conditionParameter.GetNativeParameters()
				.Concat(_parameter1.GetNativeParameters())
				.Concat(_parameter2.GetNativeParameters())
				.ToArray();
			var actualLambda = Native.Expression.Lambda(GetNativeExpression(), parameters);
			var func = actualLambda.Compile();
			if (!_conditionParameter.IsCompound && !_parameter1.IsCompound && !_parameter2.IsCompound)
			{
				return (Func<TConditionParameter, TParameter1, TParameter2, TResult>)func;
			}

			Native.Expression<Func<TConditionParameter, TParameter1, TParameter2, TResult>> wrapper =
				(conditionParameter, ifParameter, elseParameter) => (TResult)func.DynamicInvoke(
					_conditionParameter.ExtractValues(conditionParameter)
						.Concat(_parameter1.ExtractValues(ifParameter))
						.Concat(_parameter2.ExtractValues(elseParameter))
						.ToArray());

			return wrapper.Compile();
		}

		public IParameterExpression<(TConditionParameter, (TParameter1, TParameter2))> GetParameter()
			=> new CompoundParameterExpression<TConditionParameter, (TParameter1, TParameter2)>(_conditionParameter,
				new CompoundParameterExpression<TParameter1, TParameter2>(_parameter1, _parameter2));
	}
}