using System;
using Expressions.Generic.Binary.And;
using Expressions.Generic.Interfaces;

namespace Expressions.Generic
{
	public static partial class Expression
	{
		public static ParameterlessAndExpression<T> And<T>(
			IParameterlessResultExpression<T> left,
			IParameterlessResultExpression<T> right)
			where T : struct
			=> new ParameterlessAndExpression<T>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static AndExpression<T, TResult> And<T, TResult>(
			IResultExpression<T, TResult> left,
			IParameterlessResultExpression<TResult> right)
			where T : struct
			where TResult : struct
			=> new AndExpression<T, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static AndExpression<T, TResult> And<T, TResult>(
			IParameterlessResultExpression<TResult> left,
			IResultExpression<T, TResult> right)
			where T : struct
			where TResult : struct
			=> new AndExpression<T, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static AndExpression<T1, T2, TResult> And<T1, T2, TResult>(IResultExpression<T1, TResult> left,
			IResultExpression<T2, TResult> right)
			where T1 : struct
			where T2 : struct
			where TResult : struct
			=> new AndExpression<T1, T2, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));
	}
}