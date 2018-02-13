using System;
using Expressions.Generic.Base.Compilable;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Base.Binary
{
	public abstract class BinaryExpression<TPrevious1, TPrevious2, TCurrent, TResult>
		: BaseExpression<BinaryExpression<TPrevious1, TPrevious2, TCurrent, TResult>>
	{
		private readonly DoubleParameterCompilableContainer<TPrevious1, TPrevious2, TResult> _container;

		internal BinaryExpression(
			Func<Native.Expression, Native.Expression, Native.BinaryExpression> nativeExpression,
			IResultExpression<TPrevious1, TCurrent> left,
			IResultExpression<TPrevious2, TCurrent> right)
			: base(nativeExpression(left.GetNativeExpression(), right.GetNativeExpression()))
		{
			_container = new DoubleParameterCompilableContainer<TPrevious1, TPrevious2, TResult>(
				left.GetParameter(), right.GetParameter());
		}

		public IParameterExpression<(TPrevious1, TPrevious2)> GetParameter()
			=> _container.GetParameter();

		public Func<TPrevious1, TPrevious2, TResult> Compile()
			=> _container.Compile(GetNativeExpression());
	}
}