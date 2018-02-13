using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.Composite.BinaryAdd
{
	[TestClass]
	public class ParameterlessBinaryAddTests
	{
		[TestMethod]
		[TestCategory(TestConstants.BinaryAdd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void ParameterlessBinaryAddOverSame()
		{
			var innerBinary = Expression.Add(Expression.Constant(1), Expression.Constant(2));
			Assert.AreEqual<int>(3, innerBinary.Compile()(), $"Test prerequisite failed");
			var binary = Expression.Add(innerBinary, Expression.Constant(4));
			var func = binary.Compile();
			Assert.AreEqual<int>(7, func());
		}
	}
}