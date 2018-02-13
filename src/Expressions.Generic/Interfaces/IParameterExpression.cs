using Native = System.Linq.Expressions;

namespace Expressions.Generic.Interfaces
{
	public interface IParameterExpression<T>
	{
		bool IsCompound { get; }

		Native.ParameterExpression[] GetNativeParameters();

		Native.ParameterExpression GetNativeExpression();
		
		object[] ExtractValues(T value);
	}
}