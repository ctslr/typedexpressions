using System;
using Expressions.Generic.Binary.GreaterThan;
using Expressions.Generic.Interfaces;

namespace Expressions.Generic
{
	public static partial class Expression
	{
		public static ParameterlessGreaterThanExpression<T> GreaterThan<T>(
			IParameterlessResultExpression<T> left,
			IParameterlessResultExpression<T> right)
			where T : struct
			=> new ParameterlessGreaterThanExpression<T>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static GreaterThanExpression<T, TResult> GreaterThan<T, TResult>(
			IResultExpression<T, TResult> left,
			IParameterlessResultExpression<TResult> right)
			where T : struct
			where TResult : struct
			=> new GreaterThanExpression<T, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static GreaterThanExpression<T, TResult> GreaterThan<T, TResult>(
			IParameterlessResultExpression<TResult> left,
			IResultExpression<T, TResult> right)
			where T : struct
			where TResult : struct
			=> new GreaterThanExpression<T, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static GreaterThanExpression<T1, T2, TResult> GreaterThan<T1, T2, TResult>(
			IResultExpression<T1, TResult> left,
			IResultExpression<T2, TResult> right)
			where T1 : struct
			where T2 : struct
			where TResult: struct
			=> new GreaterThanExpression<T1, T2, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));
	}
}