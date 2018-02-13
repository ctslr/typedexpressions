using System;
using System.Linq;
using Expressions.Generic.Interfaces;
using Expressions.Generic.Parameter;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Base.Compilable
{
	internal class DoubleParameterCompilableContainer<TFirst, TSecond, TResult>
	{
		private readonly IParameterExpression<TFirst> _parameter1;
		private readonly IParameterExpression<TSecond> _parameter2;

		public DoubleParameterCompilableContainer(
			IParameterExpression<TFirst> first,
			IParameterExpression<TSecond> second)
		{
			_parameter1 = first;
			_parameter2 = second;
		}

		public IParameterExpression<(TFirst, TSecond)> GetParameter()
			=> new CompoundParameterExpression<TFirst, TSecond>(_parameter1, _parameter2);

		public Func<TFirst, TSecond, TResult> Compile(Native.Expression nativeExpression)
		{
			var parameters = _parameter1.GetNativeParameters()
				.Concat(_parameter2.GetNativeParameters())
				.ToArray();
			var actualLambda = Native.Expression.Lambda(nativeExpression, parameters);
			var func = actualLambda.Compile();
			if (!_parameter1.IsCompound && !_parameter2.IsCompound)
			{
				return (Func<TFirst, TSecond, TResult>)func;
			}

			Native.Expression<Func<TFirst, TSecond, TResult>> wrapper =
				(conditionParameter, parameter) => (TResult)func.DynamicInvoke(
					_parameter1.ExtractValues(conditionParameter)
						.Concat(_parameter2.ExtractValues(parameter))
						.ToArray());

			return wrapper.Compile();
		}
	}
}
