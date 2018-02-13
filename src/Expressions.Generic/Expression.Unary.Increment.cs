using System;
using Expressions.Generic.Interfaces;
using Expressions.Generic.Unary.Increment;

namespace Expressions.Generic
{
	public static partial class Expression
	{
		public static IncrementExpression<T, TResult> Increment<T, TResult>(IResultExpression<T, TResult> inner)
			=> new IncrementExpression<T, TResult>(inner ?? throw new ArgumentNullException(nameof(inner)));
	}
}