using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.Composite.BinaryOr
{
	[TestClass]
	public class MultiParameterBinaryOrTests
	{
		[TestMethod]
		[TestCategory(TestConstants.BinaryOr)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void ParameterlessBooleanBinaryOrOverSingleParameter()
		{
			var innerBinary = Expression.Or(Expression.Constant(false), Expression.Parameter<bool>());
			Assert.AreEqual<bool>(false, innerBinary.Compile()(false), $"Test prerequisite failed");
			var binary = Expression.Or(innerBinary, Expression.Constant(true));
			var func = binary.Compile();
			Assert.AreEqual<bool>(true, func(true));
			Assert.AreEqual<bool>(true, func(false));
			binary = Expression.Or(innerBinary, Expression.Constant(false));
			func = binary.Compile();
			Assert.AreEqual<bool>(true, func(true));
			Assert.AreEqual<bool>(false, func(false));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryOr)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanBinaryOrOverSingleParameter()
		{
			var innerBinary = Expression.Or(Expression.Constant(false), Expression.Parameter<bool>());
			Assert.AreEqual<bool>(true, innerBinary.Compile()(true), $"Test prerequisite failed");
			var binary = Expression.Or(innerBinary, Expression.Parameter<bool>());
			var func = binary.Compile();
			Assert.AreEqual<bool>(true, func(true, true));
			Assert.AreEqual<bool>(false, func(false, false));
			Assert.AreEqual<bool>(true, func(true, false));
			Assert.AreEqual<bool>(true, func(false, true));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryOr)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanBinaryOrOverDoubleParameter()
		{
			var innerBinary = Expression.Or(Expression.Parameter<bool>(), Expression.Parameter<bool>());
			Assert.AreEqual<bool>(true, innerBinary.Compile()(true, false), $"Test prerequisite failed");
			var binary = Expression.Or(innerBinary, Expression.Parameter<bool>());
			var func = binary.Compile();
			Assert.AreEqual<bool>(true, func((true, true), true));
			Assert.AreEqual<bool>(true, func((true, false), true));
			Assert.AreEqual<bool>(true, func((false, true), true));
			Assert.AreEqual<bool>(true, func((false, false), true));
			Assert.AreEqual<bool>(true, func((true, true), false));
			Assert.AreEqual<bool>(true, func((true, false), false));
			Assert.AreEqual<bool>(true, func((false, true), false));
			Assert.AreEqual<bool>(false, func((false, false), false));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryOr)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanBinaryOrOverParameterless()
		{
			var innerBinary = Expression.Or(Expression.Constant(false), Expression.Constant(true));
			Assert.AreEqual<bool>(true, innerBinary.Compile()(), $"Test prerequisite failed");
			var binary = Expression.Or(innerBinary, Expression.Parameter<bool>());
			var func = binary.Compile();
			Assert.AreEqual<bool>(true, func(true));
			Assert.AreEqual<bool>(true, func(false));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryOr)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanBinaryOrOverTwoTimesSelf()
		{
			var innerBinary = Expression.Or(Expression.Parameter<bool>(), Expression.Parameter<bool>());
			Assert.AreEqual<bool>(true, innerBinary.Compile()(true, false), $"Test prerequisite failed");
			var outerBinary = Expression.Or(innerBinary, Expression.Parameter<bool>());
			Assert.AreEqual<bool>(true, outerBinary.Compile()((true, false), false), $"Test prerequisite failed");
			var binary = Expression.Or(outerBinary, Expression.Parameter<bool>());
			var func = binary.Compile();
			Assert.AreEqual<bool>(true, func(((true, true), true), true));
			Assert.AreEqual<bool>(false, func(((false, false), false), false));
			Assert.AreEqual<bool>(true, func(((true, false), false), false));
			Assert.AreEqual<bool>(true, func(((false, true), false), false));
			Assert.AreEqual<bool>(true, func(((false, false), true), false));
            Assert.AreEqual<bool>(true, func(((false, false), true), true));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void BinaryOrOverTwoGreaterThanOverSelf()
        {
            var greaterThanDecimal = Expression.GreaterThan(Expression.Parameter<decimal>(), Expression.Parameter<decimal>());
            var greaterThanInt = Expression.GreaterThan(Expression.Parameter<int>(), Expression.Parameter<int>());
            var innerBinary = Expression.Or(greaterThanDecimal, greaterThanInt);
            Assert.AreEqual<bool>(true, innerBinary.Compile()((1.0m, 2.0m), (2,1)), $"Test prerequisite failed");
            var binary = Expression.Or(innerBinary, Expression.Parameter<bool>());
            var func = binary.Compile();
            Assert.AreEqual<bool>(true, func(((2.0m, 1.0m), (2, 1)), true));
            Assert.AreEqual<bool>(false, func(((1.0m, 2.0m), (1, 2)), false));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void BinaryOrOverGreaterThanAndConstantOverSelf()
        {
            var greaterThanDecimal = Expression.GreaterThan(Expression.Parameter<decimal>(), Expression.Parameter<decimal>());
            var constant = Expression.Constant(false);
            var innerBinary = Expression.Or(greaterThanDecimal, constant);
            Assert.AreEqual<bool>(false, innerBinary.Compile()((1.0m, 2.0m)), $"Test prerequisite failed");
            var binary = Expression.Or(innerBinary, Expression.Parameter<bool>());
            var func = binary.Compile();
            Assert.AreEqual<bool>(true, func((2.0m, 1.0m), true));
            Assert.AreEqual<bool>(false, func((1.0m, 2.0m), false));
            innerBinary = Expression.Or(constant, greaterThanDecimal);
            Assert.AreEqual<bool>(false, innerBinary.Compile()((1.0m, 2.0m)), $"Test prerequisite failed");
            binary = Expression.Or(innerBinary, Expression.Parameter<bool>());
            func = binary.Compile();
            Assert.AreEqual<bool>(true, func((2.0m, 1.0m), true));
            Assert.AreEqual<bool>(false, func((1.0m, 2.0m), false));
        }
    }
}