using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.Composite.BinaryAnd
{
	[TestClass]
	public class ParameterlessBinaryAndTests
	{
		[TestMethod]
		[TestCategory(TestConstants.BinaryAnd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void ParameterlessBooleanBinaryAndOverSame()
		{
			var innerBinary = Expression.And(Expression.Constant(true), Expression.Constant(true));
			Assert.AreEqual<bool>(true, innerBinary.Compile()(), $"Test prerequisite failed");
			var binary = Expression.And(innerBinary, Expression.Constant(true));
			var func = binary.Compile();
			Assert.AreEqual<bool>(true, func());
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryAnd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void ParameterlessIntegerBinaryAndOverSame()
		{
			var innerBinary = Expression.And(Expression.Constant(0x101101), Expression.Constant(0x110101));
			Assert.AreEqual<int>(0x100101, innerBinary.Compile()(), $"Test prerequisite failed");
			var binary = Expression.And(innerBinary, Expression.Constant(0x101011));
			var func = binary.Compile();
			Assert.AreEqual<int>(0x100001, func());
		}
	}
}