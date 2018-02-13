namespace Expressions.Generic.Interfaces
{
	public interface IResultExpression<TParameter, TResult> : IExpression<TResult>
	{
		IParameterExpression<TParameter> GetParameter();
	}
}