using System;
using Expressions.Generic.Interfaces;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Base
{
	/// <summary>
	/// Base class for all typed expressions
	/// </summary>
	public abstract class BaseExpression<T> : IExpression<T>
	{
		private readonly Native.Expression _nativeExpression;

		protected BaseExpression(Native.Expression native)
			=> _nativeExpression = native;

		public virtual Native.Expression GetNativeExpression()
			=> _nativeExpression;
	}
}
