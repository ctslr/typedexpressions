using System;
using Expressions.Generic.Binary.Multiply;
using Expressions.Generic.Interfaces;

namespace Expressions.Generic
{
	public static partial class Expression
	{
		public static ParameterlessMultiplyExpression<T> Multiply<T>(
			IParameterlessResultExpression<T> left,
			IParameterlessResultExpression<T> right)
			where T : struct
			=> new ParameterlessMultiplyExpression<T>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static MultiplyExpression<T, TResult> Multiply<T, TResult>(
			IResultExpression<T, TResult> left,
			IParameterlessResultExpression<TResult> right)
			where T : struct
			where TResult : struct
			=> new MultiplyExpression<T, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static MultiplyExpression<T, TResult> Multiply<T, TResult>(
			IParameterlessResultExpression<TResult> left,
			IResultExpression<T, TResult> right)
			where T : struct
			where TResult : struct
			=> new MultiplyExpression<T, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static MultiplyExpression<T1, T2, TResult> Multiply<T1, T2, TResult>(
			IResultExpression<T1, TResult> left,
			IResultExpression<T2, TResult> right)
			where T1 : struct
			where T2 : struct
			where TResult : struct
			=> new MultiplyExpression<T1, T2, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));
	}
}
