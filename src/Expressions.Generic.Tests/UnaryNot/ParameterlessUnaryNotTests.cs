using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.UnaryNot
{
	[TestClass]
	public class ParameterlessUnaryNotTests
	{
		[TestMethod]
		[TestCategory(TestConstants.UnaryNot)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void ParameterlessIntegerUnaryNot()
		{
			var constant = Expression.Constant(0);
			var not = Expression.Not(constant);
			var func = not.Compile();
			Assert.AreEqual<int>(-1, func());
			constant = Expression.Constant(1337);
			not = Expression.Not(constant);
			func = not.Compile();
			Assert.AreEqual<int>(-1338, func());
		}

		[TestMethod]
		[TestCategory(TestConstants.UnaryNot)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void ParameterlessBooleanUnaryMultipleNot()
		{
			var constant = Expression.Constant(false);
			var not = Expression.Not(constant);
			var func = not.Compile();
			Assert.AreEqual<bool>(true, func());
			constant = Expression.Constant(true);
			not = Expression.Not(constant);
			func = not.Compile();
			Assert.AreEqual<bool>(false, func());
		}
	}
}
