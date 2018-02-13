using System;
using Expressions.Generic.Binary.Add;
using Expressions.Generic.Interfaces;

namespace Expressions.Generic
{
	public static partial class Expression
	{
		public static ParameterlessAddExpression<T> Add<T>(
			IParameterlessResultExpression<T> left,
			IParameterlessResultExpression<T> right)
			where T : struct
			=> new ParameterlessAddExpression<T>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static AddExpression<T, TResult> Add<T, TResult>(
			IResultExpression<T, TResult> left,
			IParameterlessResultExpression<TResult> right)
			where T : struct
			where TResult : struct
			=> new AddExpression<T, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static AddExpression<T, TResult> Add<T, TResult>(
			IParameterlessResultExpression<TResult> left,
			IResultExpression<T, TResult> right)
			where T : struct
			where TResult : struct
			=> new AddExpression<T, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));

		public static AddExpression<T1, T2, TResult> Add<T1, T2, TResult>(
			IResultExpression<T1, TResult> left,
			IResultExpression<T2, TResult> right)
			where T1 : struct
			where T2 : struct
			where TResult: struct
			=> new AddExpression<T1, T2, TResult>(
				left ?? throw new ArgumentNullException(nameof(left)),
				right ?? throw new ArgumentNullException(nameof(right)));
	}
}