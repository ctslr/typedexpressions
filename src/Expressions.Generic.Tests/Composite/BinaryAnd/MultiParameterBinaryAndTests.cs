using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.Composite.BinaryAnd
{
	[TestClass]
	public class MultiParameterBinaryAndTests
	{
		[TestMethod]
		[TestCategory(TestConstants.BinaryAnd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void ParameterlessBooleanBinaryAndOverSingleParameter()
		{
			var innerBinary = Expression.And(Expression.Constant(true), Expression.Parameter<bool>());
			Assert.AreEqual<bool>(true, innerBinary.Compile()(true), $"Test prerequisite failed");
			var binary = Expression.And(innerBinary, Expression.Constant(true));
			var func = binary.Compile();
			Assert.AreEqual<bool>(true, func(true));
			Assert.AreEqual<bool>(false, func(false));
			binary = Expression.And(innerBinary, Expression.Constant(false));
			func = binary.Compile();
			Assert.AreEqual<bool>(false, func(true));
			Assert.AreEqual<bool>(false, func(false));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryAnd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanBinaryAndOverSingleParameter()
		{
			var innerBinary = Expression.And(Expression.Constant(true), Expression.Parameter<bool>());
			Assert.AreEqual<bool>(true, innerBinary.Compile()(true), $"Test prerequisite failed");
			var binary = Expression.And(innerBinary, Expression.Parameter<bool>());
			var func = binary.Compile();
			Assert.AreEqual<bool>(true, func(true, true));
			Assert.AreEqual<bool>(false, func(false, true));

			Assert.AreEqual<bool>(false, func(true, false));
			Assert.AreEqual<bool>(false, func(false, false));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryAnd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanBinaryAndOverDoubleParameter()
		{
			var innerBinary = Expression.And(Expression.Parameter<bool>(), Expression.Parameter<bool>());
			Assert.AreEqual<bool>(true, innerBinary.Compile()(true, true), $"Test prerequisite failed");
			var binary = Expression.And(innerBinary, Expression.Parameter<bool>());
			var func = binary.Compile();
			Assert.AreEqual<bool>(true, func((true, true), true));
			Assert.AreEqual<bool>(false, func((true, false), true));
			Assert.AreEqual<bool>(false, func((false, true), true));
			Assert.AreEqual<bool>(false, func((false, false), true));
			Assert.AreEqual<bool>(false, func((true, true), false));
			Assert.AreEqual<bool>(false, func((true, false), false));
			Assert.AreEqual<bool>(false, func((false, true), false));
			Assert.AreEqual<bool>(false, func((false, false), false));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryAnd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanBinaryAndOverParameterless()
		{
			var innerBinary = Expression.And(Expression.Constant(true), Expression.Constant(true));
			Assert.AreEqual<bool>(true, innerBinary.Compile()(), $"Test prerequisite failed");
			var binary = Expression.And(innerBinary, Expression.Parameter<bool>());
			var func = binary.Compile();
			Assert.AreEqual<bool>(true, func(true));
			Assert.AreEqual<bool>(false, func(false));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryAnd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void DoubleParameterBooleanBinaryAndOverTwoTimesSelf()
		{
			var innerBinary = Expression.And(Expression.Parameter<bool>(), Expression.Parameter<bool>());
			Assert.AreEqual<bool>(true, innerBinary.Compile()(true, true), $"Test prerequisite failed");
			var outerBinary = Expression.And(innerBinary, Expression.Parameter<bool>());
			Assert.AreEqual<bool>(true, outerBinary.Compile()((true, true), true), $"Test prerequisite failed");
			var binary = Expression.And(outerBinary, Expression.Parameter<bool>());
			var func = binary.Compile();
			Assert.AreEqual<bool>(true, func(((true, true), true), true));
			Assert.AreEqual<bool>(false, func(((false, true), true), true));
			Assert.AreEqual<bool>(false, func(((true, false), true), true));
			Assert.AreEqual<bool>(false, func(((true, true), false), true));
			Assert.AreEqual<bool>(false, func(((true, true), true), false));
		}


        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void BinaryAndOverTwoGreaterThanOverSelf()
        {
            var greaterThanDecimal = Expression.GreaterThan(Expression.Parameter<decimal>(), Expression.Parameter<decimal>());
            var greaterThanInt = Expression.GreaterThan(Expression.Parameter<int>(), Expression.Parameter<int>());
            var innerBinary = Expression.And(greaterThanDecimal, greaterThanInt);
            Assert.AreEqual<bool>(false, innerBinary.Compile()((1.0m, 2.0m), (2, 1)), $"Test prerequisite failed");
            var binary = Expression.And(innerBinary, Expression.Parameter<bool>());
            var func = binary.Compile();
            Assert.AreEqual<bool>(true, func(((2.0m, 1.0m), (2, 1)), true));
            Assert.AreEqual<bool>(false, func(((1.0m, 2.0m), (2, 1)), true));
            Assert.AreEqual<bool>(false, func(((1.0m, 2.0m), (1, 2)), false));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void BinaryAndOverGreaterThanAndConstantOverSelf()
        {
            var greaterThanDecimal = Expression.GreaterThan(Expression.Parameter<decimal>(), Expression.Parameter<decimal>());
            var constant = Expression.Constant(true);
            var innerBinary = Expression.And(greaterThanDecimal, constant);
            Assert.AreEqual<bool>(false, innerBinary.Compile()((1.0m, 2.0m)), $"Test prerequisite failed");
            var binary = Expression.And(innerBinary, Expression.Parameter<bool>());
            var func = binary.Compile();
            Assert.AreEqual<bool>(true, func((2.0m, 1.0m), true));
            Assert.AreEqual<bool>(false, func((1.0m, 2.0m), true));
            innerBinary = Expression.And(constant, greaterThanDecimal);
            Assert.AreEqual<bool>(true, innerBinary.Compile()((2.0m, 1.0m)), $"Test prerequisite failed");
            binary = Expression.And(innerBinary, Expression.Parameter<bool>());
            func = binary.Compile();
            Assert.AreEqual<bool>(true, func((2.0m, 1.0m), true));
            Assert.AreEqual<bool>(false, func((1.0m, 2.0m), false));
        }

    }
}