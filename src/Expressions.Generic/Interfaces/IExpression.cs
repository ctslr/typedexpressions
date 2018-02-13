using Native = System.Linq.Expressions;

namespace Expressions.Generic.Interfaces
{
	/// <summary>
	/// Base interface for all expressions
	/// </summary>
	public interface IExpression<T>
	{
		Native.Expression GetNativeExpression();
	}
}
