using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.Composite.BinaryOr
{
	[TestClass]
	public class ParameterlessBinaryOrTests
	{
		[TestMethod]
		[TestCategory(TestConstants.BinaryOr)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void ParameterlessBooleanBinaryOrOverSame()
		{
			var innerBinary = Expression.Or(Expression.Constant(true), Expression.Constant(false));
			Assert.AreEqual<bool>(true, innerBinary.Compile()(), $"Test prerequisite failed");
			var binary = Expression.Or(innerBinary, Expression.Constant(true));
			var func = binary.Compile();
			Assert.AreEqual<bool>(true, func());
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryOr)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void ParameterlessIntegerBinaryOrOverSame()
		{
			var innerBinary = Expression.Or(Expression.Constant(0x101101), Expression.Constant(0x110101));
			Assert.AreEqual<int>(0x111101, innerBinary.Compile()(), $"Test prerequisite failed");
			var binary = Expression.Or(innerBinary, Expression.Constant(0x101011));
			var func = binary.Compile();
			Assert.AreEqual<int>(0x111111, func());
		}
	}
}