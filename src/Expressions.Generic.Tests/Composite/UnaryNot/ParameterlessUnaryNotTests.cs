using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.Composite.UnaryNot
{
	[TestClass]
	public class ParameterlessUnaryNotTests
	{
		[TestMethod]
		[TestCategory(TestConstants.UnaryNot)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void ParameterlessIntegerUnaryNotOverBinaryAnd()
		{
			var binary = Expression.And(Expression.Constant(0b01101), Expression.Constant(0b11001));
			Assert.AreEqual<int>(0b01001, binary.Compile()(), $"Test prerequisite failed");
			var not = Expression.Not(binary);
			var func = not.Compile();
			Assert.AreEqual<int>(-10, func());
		}

		[TestMethod]
		[TestCategory(TestConstants.UnaryNot)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void ParameterlessIntegerUnaryNotOverBinaryOr()
		{
			var binary = Expression.Or(Expression.Constant(0b01101), Expression.Constant(0b11001));
			Assert.AreEqual<int>(0b11101, binary.Compile()(), $"Test prerequisite failed");
			var not = Expression.Not(binary);
			var func = not.Compile();
			Assert.AreEqual<int>(-30, func());
		}

		[TestMethod]
		[TestCategory(TestConstants.UnaryNot)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void ParameterlessBooleanUnaryNotOverBinaryAnd()
		{
			var binary = Expression.And(Expression.Constant(true), Expression.Constant(true));
			Assert.AreEqual<bool>(true, binary.Compile()(), $"Test prerequisite failed");
			var not = Expression.Not(binary);
			var func = not.Compile();
			Assert.AreEqual<bool>(false, func());
		}

		[TestMethod]
		[TestCategory(TestConstants.UnaryNot)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void ParameterlessBooleanUnaryNotOverBinaryOr()
		{
			var binary = Expression.Or(Expression.Constant(true), Expression.Constant(true));
			Assert.AreEqual<bool>(true, binary.Compile()(), $"Test prerequisite failed");
			var not = Expression.Not(binary);
			var func = not.Compile();
			Assert.AreEqual<bool>(false, func());
		}
	}
}
