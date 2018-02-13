using Expressions.Generic.Base;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Parameter
{
	public class ParameterExpression<T> : BaseExpression<ParameterExpression<T>>, IParameterExpression<T>,
		IResultExpression<T, T>
	{
		internal ParameterExpression() : base(Native.Expression.Parameter(typeof(T)))
		{
		}

		public bool IsCompound => false;

		public Native.ParameterExpression[] GetNativeParameters()
			=> new[] { GetNativeExpression() };

		public new Native.ParameterExpression GetNativeExpression()
			=> (Native.ParameterExpression)base.GetNativeExpression();

		public IParameterExpression<T> GetParameter()
			=> this;

		public object[] ExtractValues(T value)
			=> new object[] { value };
	}
}