using System;
using Expressions.Generic.Base.Compilable;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Base.Binary
{
	public abstract class ParameterlessBinaryExpression<T, TResult>
		: ParameterlessCompilableExpression<TResult, ParameterlessBinaryExpression<T, TResult>>
	{
		internal ParameterlessBinaryExpression(
			Func<Native.Expression, Native.Expression, Native.BinaryExpression> nativeExpression,
			IParameterlessResultExpression<T> left,
			IParameterlessResultExpression<T> right)
			: base(nativeExpression(left.GetNativeExpression(), right.GetNativeExpression()))
		{
		}
	}
}