using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.Composite.BinaryMultiply
{
	[TestClass]
	public class ParameterlessBinaryMultiplyTests
	{
		[TestMethod]
		[TestCategory(TestConstants.BinaryMultiply)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void ParameterlessBinaryMultiplyOverSame()
		{
			var innerBinary = Expression.Multiply(Expression.Constant(2), Expression.Constant(3));
			Assert.AreEqual<int>(6, innerBinary.Compile()(), $"Test prerequisite failed");
			var binary = Expression.Multiply(innerBinary, Expression.Constant(4));
			var func = binary.Compile();
			Assert.AreEqual<int>(24, func());
		}
	}
}