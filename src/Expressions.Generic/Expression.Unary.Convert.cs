using System;
using Expressions.Generic.Interfaces;
using Expressions.Generic.Unary.Convert;

namespace Expressions.Generic
{
	public static partial class Expression
	{
		public static ConvertExpression<TPrevious, TCurrent, int> ConvertToInt<TPrevious, TCurrent>(
			IResultExpression<TPrevious, TCurrent> inner)
			where TCurrent : struct
			=> new ConvertExpression<TPrevious, TCurrent, int>(
				inner ?? throw new ArgumentNullException(nameof(inner)));
	}
}