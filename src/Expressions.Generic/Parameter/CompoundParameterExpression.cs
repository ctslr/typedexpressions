using System.Linq;
using Native = System.Linq.Expressions;
using Expressions.Generic.Interfaces;

namespace Expressions.Generic.Parameter
{
	public class CompoundParameterExpression<T1, T2> : IParameterExpression<(T1, T2)>
	{
		private readonly IParameterExpression<T1> _first;
		private readonly IParameterExpression<T2> _second;

		public bool IsCompound => true;

		internal CompoundParameterExpression(IParameterExpression<T1> first, IParameterExpression<T2> second)
		{
			_first = first;
			_second = second;
		}
		
		public Native.ParameterExpression GetNativeExpression()
			=> throw new System.NotImplementedException();

		public Native.ParameterExpression[] GetNativeParameters()
			=> _first.GetNativeParameters().Concat(_second.GetNativeParameters()).ToArray();

		public object[] ExtractValues((T1, T2) value)
			=> _first.ExtractValues(value.Item1).Concat(_second.ExtractValues(value.Item2)).ToArray();
	}
}
