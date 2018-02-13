using System;
using Expressions.Generic.Binary.Or;
using Expressions.Generic.Interfaces;

namespace Expressions.Generic
{
	public static partial class Expression
	{
		public static ParameterlessOrExpression<T> Or<T>(
			IParameterlessResultExpression<T> left,
			IParameterlessResultExpression<T> right)
			where T : struct
			=> new ParameterlessOrExpression<T>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static OrExpression<T, TResult> Or<T, TResult>(
			IResultExpression<T, TResult> left,
			IParameterlessResultExpression<TResult> right)
			where T : struct
			where TResult : struct
			=> new OrExpression<T, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static OrExpression<T, TResult> Or<T, TResult>(
			IParameterlessResultExpression<TResult> left,
			IResultExpression<T, TResult> right)
			where T : struct
			where TResult : struct
			=> new OrExpression<T, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static OrExpression<T1, T2, TResult> Or<T1, T2, TResult>(
			IResultExpression<T1, TResult> left,
			IResultExpression<T2, TResult> right)
			where T1 : struct
			where T2 : struct
			=> new OrExpression<T1, T2, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));
	}
}