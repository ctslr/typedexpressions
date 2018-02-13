using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.Composite.BinaryEqual
{
	[TestClass]
	public class MultiParameterBinaryEqualTests
	{
		[TestMethod]
		[TestCategory(TestConstants.BinaryEqual)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void ParameterlessIntBinaryEqualOverSingleParameter()
		{
			var innerBinary = Expression.Equal(Expression.Constant(1), Expression.Parameter<int>());
			Assert.AreEqual<bool>(false, innerBinary.Compile()(2), $"Test prerequisite failed");
			var binary = Expression.Equal(innerBinary, Expression.Constant(true));
			var func = binary.Compile();
			Assert.AreEqual<bool>(true, func(1));
			Assert.AreEqual<bool>(false, func(2));
			binary = Expression.Equal(innerBinary, Expression.Constant(false));
			func = binary.Compile();
			Assert.AreEqual<bool>(false, func(1));
			Assert.AreEqual<bool>(true, func(2));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryEqual)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterIntBinaryEqualOverSingleParameter()
		{
			var innerBinary = Expression.Equal(Expression.Constant(1), Expression.Parameter<int>());
			Assert.AreEqual<bool>(true, innerBinary.Compile()(1), $"Test prerequisite failed");
			var binary = Expression.Equal(innerBinary, Expression.Parameter<bool>());
			var func = binary.Compile();
			Assert.AreEqual<bool>(true, func(1, true));
			Assert.AreEqual<bool>(true, func(2, false));
			Assert.AreEqual<bool>(false, func(1, false));
			Assert.AreEqual<bool>(false, func(2, true));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryEqual)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterIntBinaryEqualOverDoubleParameter()
		{
			var innerBinary = Expression.Equal(Expression.Parameter<int>(), Expression.Parameter<int>());
			Assert.AreEqual<bool>(true, innerBinary.Compile()(1, 1), $"Test prerequisite failed");
			var binary = Expression.Equal(innerBinary, Expression.Parameter<bool>());
			var func = binary.Compile();
			Assert.AreEqual<bool>(true, func((1, 1), true));
			Assert.AreEqual<bool>(false, func((1, 2), true));
			Assert.AreEqual<bool>(false, func((1, 1), false));
			Assert.AreEqual<bool>(true, func((1, 2), false));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryEqual)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterIntBinaryEqualOverParameterless()
		{
			var innerBinary = Expression.Equal(Expression.Constant(1), Expression.Constant(1));
			Assert.AreEqual<bool>(true, innerBinary.Compile()(), $"Test prerequisite failed");
			var binary = Expression.Equal(innerBinary, Expression.Parameter<bool>());
			var func = binary.Compile();
			Assert.AreEqual<bool>(true, func(true));
			Assert.AreEqual<bool>(false, func(false));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryEqual)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterIntBinaryEqualOverTwoTimesSelf()
		{
			var innerBinary = Expression.Equal(Expression.Parameter<int>(), Expression.Parameter<int>());
			Assert.AreEqual<bool>(true, innerBinary.Compile()(1, 1), $"Test prerequisite failed");
			var outerBinary = Expression.Equal(innerBinary, Expression.Parameter<bool>());
			Assert.AreEqual<bool>(false, outerBinary.Compile()((1, 1), false), $"Test prerequisite failed");
			var binary = Expression.Equal(outerBinary, Expression.Parameter<bool>());
			var func = binary.Compile();
			Assert.AreEqual<bool>(true, func(((1, 1), true), true));
			Assert.AreEqual<bool>(false, func(((1, 2), false), false));
			Assert.AreEqual<bool>(true, func(((1, 2), false), true));
			Assert.AreEqual<bool>(true, func(((1, 1), false), false));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryEqual)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void BinaryEqualOverTwoGreaterThanOverSelf()
        {
            var greaterThanDecimal = Expression.GreaterThan(Expression.Parameter<decimal>(), Expression.Parameter<decimal>());
            var greaterThanInt = Expression.GreaterThan(Expression.Parameter<int>(), Expression.Parameter<int>());
            var innerBinary = Expression.Equal(greaterThanDecimal, greaterThanInt);
            Assert.AreEqual<bool>(false, innerBinary.Compile()((1.0m, 2.0m), (2,1)), $"Test prerequisite failed");
            var binary = Expression.Equal(innerBinary, Expression.Parameter<bool>());
            var func = binary.Compile();
            Assert.AreEqual<bool>(true, func(((2.0m, 1.0m), (2, 1)), true));
            Assert.AreEqual<bool>(false, func(((1.0m, 2.0m), (1, 2)), false));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryEqual)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void BinaryEqualOverGreaterThanAndConstantOverSelf()
        {
            var greaterThanDecimal = Expression.GreaterThan(Expression.Parameter<decimal>(), Expression.Parameter<decimal>());
            var constant = Expression.Constant(false);
            var innerBinary = Expression.Equal(greaterThanDecimal, constant);
            Assert.AreEqual<bool>(true, innerBinary.Compile()((1.0m, 2.0m)), $"Test prerequisite failed");
            var binary = Expression.Equal(innerBinary, Expression.Parameter<bool>());
            var func = binary.Compile();
            Assert.AreEqual<bool>(false, func((2.0m, 1.0m), true));
            Assert.AreEqual<bool>(false, func((1.0m, 1.0m), false));
            innerBinary = Expression.Equal(constant, greaterThanDecimal);
            Assert.AreEqual<bool>(true, innerBinary.Compile()((1.0m, 1.0m)), $"Test prerequisite failed");
            binary = Expression.Equal(innerBinary, Expression.Parameter<bool>());
            func = binary.Compile();
            Assert.AreEqual<bool>(true, func((1.0m, 1.0m), true));
            Assert.AreEqual<bool>(false, func((1.0m, 2.0m), false));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryEqual)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void BinaryEqualOverTwoConvertOverSelf()
        {
            var convertShort = Expression.ConvertToInt(Expression.Parameter<short>());
            var convertInt = Expression.ConvertToInt(Expression.Parameter<decimal>());
            var innerBinary = Expression.Equal(convertShort, convertInt);
            Assert.AreEqual<bool>(true, innerBinary.Compile()(1, 1.0m), $"Test prerequisite failed");
            var binary = Expression.Equal(innerBinary, Expression.Parameter<bool>());
            var func = binary.Compile();
            Assert.AreEqual<bool>(true, func((2, 2.0m), true));
            Assert.AreEqual<bool>(true, func((1, 2.0m), false));
        }

    }
}