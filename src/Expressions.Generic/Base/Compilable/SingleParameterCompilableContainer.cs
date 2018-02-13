using System;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Base.Compilable
{
	internal class SingleParameterCompilableContainer<TParameter, TResult>
	{
		private readonly IParameterExpression<TParameter> _parameter;

		public SingleParameterCompilableContainer(IParameterExpression<TParameter> parameter)
		{
			_parameter = parameter;
		}

		public IParameterExpression<TParameter> GetParameter()
			=> _parameter;

		public Func<TParameter, TResult> Compile(Native.Expression nativeExpression)
		{
			var parameters = _parameter.GetNativeParameters();
			var actualLambda = Native.Expression.Lambda(nativeExpression, parameters);
			var func = actualLambda.Compile();
			if (!_parameter.IsCompound)
			{
				return (Func<TParameter, TResult>)func;
			}

			Native.Expression<Func<TParameter, TResult>> wrapper = q
				=> (TResult)func.DynamicInvoke(_parameter.ExtractValues(q));

			return wrapper.Compile();
		}
	}
}
