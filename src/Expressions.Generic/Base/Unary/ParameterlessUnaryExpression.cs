using System;
using Expressions.Generic.Base.Compilable;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Base.Unary
{
	public abstract class ParameterlessUnaryExpression<T, TResult>
		: ParameterlessCompilableExpression<TResult, ParameterlessUnaryExpression<T, TResult>>
	{
		internal ParameterlessUnaryExpression(
			Func<Native.Expression, Native.UnaryExpression> nativeExpression,
			IParameterlessResultExpression<T> constant) : base(nativeExpression(constant.GetNativeExpression()))
		{
		}
	}
}