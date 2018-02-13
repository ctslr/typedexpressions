using System;
using Expressions.Generic.Base;
using Expressions.Generic.Base.Compilable;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Condition
{
	public sealed class ConstantConditionExpression<TParameter, TResult>
		: BaseExpression<ConditionExpression<TParameter, TResult>>,
		IResultExpression<TParameter, TResult>
	{
		private readonly SingleParameterCompilableContainer<TParameter, TResult> _container;

		public ConstantConditionExpression(IParameterlessResultExpression<bool> condition,
			IResultExpression<TParameter, TResult> ifExpression,
			IParameterlessResultExpression<TResult> elseExpression)
			: base(Native.Expression.Condition(condition.GetNativeExpression(), ifExpression.GetNativeExpression(),
				elseExpression.GetNativeExpression()))
		{
			_container = new SingleParameterCompilableContainer<TParameter, TResult>(ifExpression.GetParameter());
		}

		public ConstantConditionExpression(IParameterlessResultExpression<bool> condition,
			IParameterlessResultExpression<TResult> ifExpression,
			IResultExpression<TParameter, TResult> elseExpression)
			: base(Native.Expression.Condition(condition.GetNativeExpression(), ifExpression.GetNativeExpression(),
				elseExpression.GetNativeExpression()))
		{
			_container = new SingleParameterCompilableContainer<TParameter, TResult>(elseExpression.GetParameter());
		}

		public IParameterExpression<TParameter> GetParameter()
			=> _container.GetParameter();

		public Func<TParameter, TResult> Compile()
			=> _container.Compile(GetNativeExpression());
	}
}