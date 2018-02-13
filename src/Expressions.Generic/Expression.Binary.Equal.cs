using System;
using Expressions.Generic.Binary.Equal;
using Expressions.Generic.Interfaces;

namespace Expressions.Generic
{
	public static partial class Expression
	{
		public static ParameterlessEqualExpression<T> Equal<T>(
			IParameterlessResultExpression<T> left,
			IParameterlessResultExpression<T> right)
			where T : struct
			=> new ParameterlessEqualExpression<T>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static EqualExpression<T, TResult> Equal<T, TResult>(
			IResultExpression<T, TResult> left,
			IParameterlessResultExpression<TResult> right)
			=> new EqualExpression<T, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static EqualExpression<T, TResult> Equal<T, TResult>(
			IParameterlessResultExpression<TResult> left,
			IResultExpression<T, TResult> right)
			=> new EqualExpression<T, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static EqualExpression<T1, T2, TResult> Equal<T1, T2, TResult>(IResultExpression<T1, TResult> left,
			IResultExpression<T2, TResult> right)
			=> new EqualExpression<T1, T2, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));
	}
}