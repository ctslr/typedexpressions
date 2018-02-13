using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.Composite.BinaryMultiply
{
	[TestClass]
	public class MultiParameterBinaryMultiplyTests
	{
		[TestMethod]
		[TestCategory(TestConstants.BinaryMultiply)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void ParameterlessBooleanBinaryMultiplyOverSingleParameter()
		{
			var innerBinary = Expression.Multiply(Expression.Constant(2), Expression.Parameter<int>());
			Assert.AreEqual<int>(6, innerBinary.Compile()(3), $"Test prerequisite failed");
			var binary = Expression.Multiply(innerBinary, Expression.Constant(4));
			var func = binary.Compile();
			Assert.AreEqual<int>(40, func(5));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryMultiply)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanBinaryMultiplyOverSingleParameter()
		{
			var innerBinary = Expression.Multiply(Expression.Constant(2), Expression.Parameter<int>());
			Assert.AreEqual<int>(6, innerBinary.Compile()(3), $"Test prerequisite failed");
			var binary = Expression.Multiply(innerBinary, Expression.Parameter<int>());
			var func = binary.Compile();
			Assert.AreEqual<int>(40, func(4, 5));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryMultiply)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanBinaryMultiplyOverDoubleParameter()
		{
			var innerBinary = Expression.Multiply(Expression.Parameter<int>(), Expression.Parameter<int>());
			Assert.AreEqual<int>(6, innerBinary.Compile()(2, 3), $"Test prerequisite failed");
			var binary = Expression.Multiply(innerBinary, Expression.Parameter<int>());
			var func = binary.Compile();
			Assert.AreEqual<int>(120, func((4, 5), 6));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryMultiply)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanBinaryMultiplyOverParameterless()
		{
			var innerBinary = Expression.Multiply(Expression.Constant(2), Expression.Constant(3));
			Assert.AreEqual<int>(6, innerBinary.Compile()(), $"Test prerequisite failed");
			var binary = Expression.Multiply(innerBinary, Expression.Parameter<int>());
			var func = binary.Compile();
			Assert.AreEqual<int>(24, func(4));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryMultiply)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanBinaryMultiplyOverTwoTimesSelf()
		{
			var innerBinary = Expression.Multiply(Expression.Parameter<int>(), Expression.Parameter<int>());
			Assert.AreEqual<int>(6, innerBinary.Compile()(2, 3), $"Test prerequisite failed");
			var outerBinary = Expression.Multiply(innerBinary, Expression.Parameter<int>());
			Assert.AreEqual<int>(24, outerBinary.Compile()((2, 3), 4), $"Test prerequisite failed");
			var binary = Expression.Multiply(outerBinary, Expression.Parameter<int>());
			var func = binary.Compile();
			Assert.AreEqual<int>(120, func(((2, 3), 5), 4));
		}
	}
}