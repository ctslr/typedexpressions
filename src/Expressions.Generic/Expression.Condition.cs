using System;
using Expressions.Generic.Condition;
using Expressions.Generic.Interfaces;

namespace Expressions.Generic
{
    public static partial class Expression
    {
		public static ParameterlessConditionExpression<TResult> Condition<TResult>(
			IParameterlessResultExpression<bool> condition,
			IParameterlessResultExpression<TResult> ifExpression,
			IParameterlessResultExpression<TResult> elseExpression)
			=> new ParameterlessConditionExpression<TResult>(
				condition ?? throw new ArgumentNullException(nameof(condition)),
				ifExpression ?? throw new ArgumentNullException(nameof(ifExpression)),
				elseExpression ?? throw new ArgumentNullException(nameof(elseExpression)));

		public static ConstantConditionExpression<TParameter, TResult> Condition<TParameter, TResult>(
			IParameterlessResultExpression<bool> condition,
			IResultExpression<TParameter, TResult> ifExpression,
			IParameterlessResultExpression<TResult> elseExpression)
			=> new ConstantConditionExpression<TParameter, TResult>(
				condition ?? throw new ArgumentNullException(nameof(condition)),
				ifExpression ?? throw new ArgumentNullException(nameof(ifExpression)),
				elseExpression ?? throw new ArgumentNullException(nameof(elseExpression)));

		public static ConstantConditionExpression<TParameter, TResult> Condition<TParameter, TResult>(
			IParameterlessResultExpression<bool> condition,
			IParameterlessResultExpression<TResult> ifExpression,
			IResultExpression<TParameter, TResult> elseExpression)
			=> new ConstantConditionExpression<TParameter, TResult>(
				condition ?? throw new ArgumentNullException(nameof(condition)),
				ifExpression ?? throw new ArgumentNullException(nameof(ifExpression)),
				elseExpression ?? throw new ArgumentNullException(nameof(elseExpression)));

		public static ConstantConditionExpression<TParameter1, TParameter2, TResult>
			Condition<TParameter1, TParameter2, TResult>(
				IParameterlessResultExpression<bool> condition,
				IResultExpression<TParameter1, TResult> ifExpression,
				IResultExpression<TParameter2, TResult> elseExpression)
				=> new ConstantConditionExpression<TParameter1, TParameter2, TResult>(
					condition ?? throw new ArgumentNullException(nameof(condition)),
					ifExpression ?? throw new ArgumentNullException(nameof(ifExpression)),
					elseExpression ?? throw new ArgumentNullException(nameof(elseExpression)));

		public static ConditionExpression<TConditionParameter, TResult> Condition<TConditionParameter, TResult>(
			IResultExpression<TConditionParameter, bool> condition,
			IParameterlessResultExpression<TResult> ifExpression,
			IParameterlessResultExpression<TResult> elseExpression)
			=> new ConditionExpression<TConditionParameter, TResult>(
				condition ?? throw new ArgumentNullException(nameof(condition)),
				ifExpression ?? throw new ArgumentNullException(nameof(ifExpression)),
				elseExpression ?? throw new ArgumentNullException(nameof(elseExpression)));

		public static ConditionExpression<TConditionParameter, TParameter, TResult>
			Condition<TConditionParameter, TParameter, TResult>(
				IResultExpression<TConditionParameter, bool> condition,
				IResultExpression<TParameter, TResult> ifExpression,
				IParameterlessResultExpression<TResult> elseExpression)
				=> new ConditionExpression<TConditionParameter, TParameter, TResult>(
					condition ?? throw new ArgumentNullException(nameof(condition)),
					ifExpression ?? throw new ArgumentNullException(nameof(ifExpression)),
					elseExpression ?? throw new ArgumentNullException(nameof(elseExpression)));

		public static ConditionExpression<TConditionParameter, TParameter, TResult>
			Condition<TConditionParameter, TParameter, TResult>(
				IResultExpression<TConditionParameter, bool> condition,
				IParameterlessResultExpression<TResult> ifExpression,
				IResultExpression<TParameter, TResult> elseExpression)
				=> new ConditionExpression<TConditionParameter, TParameter, TResult>(
					condition ?? throw new ArgumentNullException(nameof(condition)),
					ifExpression ?? throw new ArgumentNullException(nameof(ifExpression)),
					elseExpression ?? throw new ArgumentNullException(nameof(elseExpression)));

		public static ConditionExpression<TConditionParameter, TParameter1, TParameter2, TResult>
			Condition<TConditionParameter, TParameter1, TParameter2, TResult>(
				IResultExpression<TConditionParameter, bool> condition,
				IResultExpression<TParameter1, TResult> ifExpression,
				IResultExpression<TParameter2, TResult> elseExpression)
				=> new ConditionExpression<TConditionParameter, TParameter1, TParameter2, TResult>(
					condition ?? throw new ArgumentNullException(nameof(condition)),
					ifExpression ?? throw new ArgumentNullException(nameof(ifExpression)),
					elseExpression ?? throw new ArgumentNullException(nameof(elseExpression)));
	}
}