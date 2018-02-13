using System;
using Expressions.Generic.Base;
using Expressions.Generic.Base.Compilable;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Condition
{
	public sealed class ConditionExpression<TConditionParameter, TParameter, TResult>
		: BaseExpression<ConditionExpression<TConditionParameter, TParameter, TResult>>,
		IResultExpression<(TConditionParameter, TParameter), TResult>
	{
		private readonly DoubleParameterCompilableContainer<TConditionParameter, TParameter, TResult> _container;

		public ConditionExpression(IResultExpression<TConditionParameter, bool> condition,
			IResultExpression<TParameter, TResult> ifExpression,
			IParameterlessResultExpression<TResult> elseExpression)
			: base(Native.Expression.Condition(condition.GetNativeExpression(), ifExpression.GetNativeExpression(),
				elseExpression.GetNativeExpression()))
		{
			_container = new DoubleParameterCompilableContainer<TConditionParameter, TParameter, TResult>(
				condition.GetParameter(), ifExpression.GetParameter());
		}

		public ConditionExpression(IResultExpression<TConditionParameter, bool> condition,
			IParameterlessResultExpression<TResult> ifExpression,
			IResultExpression<TParameter, TResult> elseExpression)
			: base(Native.Expression.Condition(condition.GetNativeExpression(), ifExpression.GetNativeExpression(),
				elseExpression.GetNativeExpression()))
		{
			_container = new DoubleParameterCompilableContainer<TConditionParameter, TParameter, TResult>(
				condition.GetParameter(), elseExpression.GetParameter());
		}

		public Func<TConditionParameter, TParameter, TResult> Compile()
			=> _container.Compile(GetNativeExpression());

		public IParameterExpression<(TConditionParameter, TParameter)> GetParameter()
			=> _container.GetParameter();
	}
}