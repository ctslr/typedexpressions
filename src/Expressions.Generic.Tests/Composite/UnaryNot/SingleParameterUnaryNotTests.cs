using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.Composite.UnaryNot
{
	[TestClass]
	public class SingleParameterUnaryNotTests
	{
		[TestMethod]
		[TestCategory(TestConstants.UnaryNot)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void SingleParameterBooleanUnaryNotOverBinaryAnd()
		{
			var binary = Expression.And(Expression.Constant(true), Expression.Parameter<bool>());
			Assert.AreEqual<bool>(true, binary.Compile()(true), $"Test prerequisite failed");
			var not = Expression.Not(binary);
			var func = not.Compile();
			Assert.AreEqual<bool>(false, func(true));
		}

		[TestMethod]
		[TestCategory(TestConstants.UnaryNot)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void SingleParameterBooleanUnaryNotOverBinaryOr()
		{
			var binary = Expression.Or(Expression.Constant(false), Expression.Parameter<bool>());
			Assert.AreEqual<bool>(true, binary.Compile()(true), $"Test prerequisite failed");
			var not = Expression.Not(binary);
			var func = not.Compile();
			Assert.AreEqual<bool>(false, func(true));
		}
	}
}
