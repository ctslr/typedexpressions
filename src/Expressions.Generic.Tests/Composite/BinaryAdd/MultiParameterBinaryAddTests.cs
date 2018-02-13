using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.Composite.BinaryAdd
{
	[TestClass]
	public class MultiParameterBinaryAddTests
	{
		[TestMethod]
		[TestCategory(TestConstants.BinaryAdd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void ParameterlessBooleanBinaryAddOverSingleParameter()
		{
			var innerBinary = Expression.Add(Expression.Constant(1), Expression.Parameter<int>());
			Assert.AreEqual<int>(3, innerBinary.Compile()(2), $"Test prerequisite failed");
			var binary = Expression.Add(innerBinary, Expression.Constant(4));
			var func = binary.Compile();
			Assert.AreEqual<int>(10, func(5));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryAdd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanBinaryAddOverSingleParameter()
		{
			var innerBinary = Expression.Add(Expression.Constant(1), Expression.Parameter<int>());
			Assert.AreEqual<int>(3, innerBinary.Compile()(2), $"Test prerequisite failed");
			var binary = Expression.Add(innerBinary, Expression.Parameter<int>());
			var func = binary.Compile();
			Assert.AreEqual<int>(10, func(4, 5));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryAdd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanBinaryAddOverDoubleParameter()
		{
			var innerBinary = Expression.Add(Expression.Parameter<int>(), Expression.Parameter<int>());
			Assert.AreEqual<int>(3, innerBinary.Compile()(1, 2), $"Test prerequisite failed");
			var binary = Expression.Add(innerBinary, Expression.Parameter<int>());
			var func = binary.Compile();
			Assert.AreEqual<int>(15, func((4, 5), 6));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryAdd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanBinaryAddOverParameterless()
		{
			var innerBinary = Expression.Add(Expression.Constant(1), Expression.Constant(2));
			Assert.AreEqual<int>(3, innerBinary.Compile()(), $"Test prerequisite failed");
			var binary = Expression.Add(innerBinary, Expression.Parameter<int>());
			var func = binary.Compile();
			Assert.AreEqual<int>(7, func(4));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryAdd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanBinaryAddOverTwoTimesSelf()
		{
			var innerBinary = Expression.Add(Expression.Parameter<int>(), Expression.Parameter<int>());
			Assert.AreEqual<int>(3, innerBinary.Compile()(1, 2), $"Test prerequisite failed");
			var outerBinary = Expression.Add(innerBinary, Expression.Parameter<int>());
			Assert.AreEqual<int>(6, outerBinary.Compile()((1, 2), 3), $"Test prerequisite failed");
			var binary = Expression.Add(outerBinary, Expression.Parameter<int>());
			var func = binary.Compile();
			Assert.AreEqual<int>(10, func(((1, 2), 3), 4));
		}
	}
}