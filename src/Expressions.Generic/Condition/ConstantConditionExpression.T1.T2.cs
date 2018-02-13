using System;
using Expressions.Generic.Base;
using Expressions.Generic.Base.Compilable;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Condition
{
	public sealed class ConstantConditionExpression<TParameter1, TParameter2, TResult>
		: BaseExpression<ConditionExpression<TParameter1, TParameter2, TResult>>,
		IResultExpression<(TParameter1, TParameter2), TResult>
	{
		private readonly DoubleParameterCompilableContainer<TParameter1, TParameter2, TResult> _container;

		public ConstantConditionExpression(IParameterlessResultExpression<bool> condition,
			IResultExpression<TParameter1, TResult> ifExpression,
			IResultExpression<TParameter2, TResult> elseExpression)
			: base(Native.Expression.Condition(condition.GetNativeExpression(), ifExpression.GetNativeExpression(),
				elseExpression.GetNativeExpression()))
		{
			_container = new DoubleParameterCompilableContainer<TParameter1, TParameter2, TResult>(
				ifExpression.GetParameter(), elseExpression.GetParameter());
		}

		public IParameterExpression<(TParameter1, TParameter2)> GetParameter()
			=> _container.GetParameter();

		public Func<TParameter1, TParameter2, TResult> Compile()
			=> _container.Compile(GetNativeExpression());
	}
}