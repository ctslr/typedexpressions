using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.Composite.UnaryNot
{
	[TestClass]
	public class DoubleParameterUnaryNotTests
	{
		[TestMethod]
		[TestCategory(TestConstants.UnaryNot)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanUnaryNotOverBinaryAnd()
		{
			var binary = Expression.And(Expression.Parameter<bool>(), Expression.Parameter<bool>());
			Assert.AreEqual<bool>(true, binary.Compile()(true, true), $"Test prerequisite failed");
			var not = Expression.Not(binary);
			var func = not.Compile();
			Assert.AreEqual<bool>(false, func((true, true)));
		}

		[TestMethod]
		[TestCategory(TestConstants.UnaryNot)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanUnaryNotOverBinaryOr()
		{
			var binary = Expression.Or(Expression.Parameter<bool>(), Expression.Parameter<bool>());
			Assert.AreEqual<bool>(true, binary.Compile()(true, false), $"Test prerequisite failed");
			var not = Expression.Not(binary);
			var func = not.Compile();
			Assert.AreEqual<bool>(false, func((true, false)));
		}
	}
}