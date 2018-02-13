using System;
using Expressions.Generic.Interfaces;
using Expressions.Generic.Unary.Not;

namespace Expressions.Generic
{
	public static partial class Expression
	{
		public static ParameterlessNotExpression<int> Not(IParameterlessResultExpression<int> constant)
			=> new ParameterlessNotExpression<int>(constant ?? throw new ArgumentNullException(nameof(constant)));

		public static ParameterlessNotExpression<bool> Not(IParameterlessResultExpression<bool> constant)
			=> new ParameterlessNotExpression<bool>(constant ?? throw new ArgumentNullException(nameof(constant)));

		public static NotExpression<T, int> Not<T>(IResultExpression<T, int> inner)
			=> new NotExpression<T, int>(inner ?? throw new ArgumentNullException(nameof(inner)));

		public static NotExpression<T, bool> Not<T>(IResultExpression<T, bool> inner)
			=> new NotExpression<T, bool>(inner ?? throw new ArgumentNullException(nameof(inner)));
	}
}