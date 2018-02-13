using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryAnd
{
	[TestClass]
	public class DoubleParameterBinaryMultiplyTests
	{
		[TestMethod]
		[TestCategory(TestConstants.BinaryMultiply)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void DoubleParameterBinaryMultiplyShort()
		{
			var result = Expression
				.Multiply(
					Expression.Parameter<short>(),
					Expression.Parameter<short>())
				.Compile();
			Assert.AreEqual<short>(22, result(11, 2));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryMultiply)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void DoubleParameterBinaryMultiplyInteger()
		{
			var result = Expression
				.Multiply(
					Expression.Parameter<int>(),
					Expression.Parameter<int>())
				.Compile();
			Assert.AreEqual<int>(42, result(21, 2));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryMultiply)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void DoubleParameterBinaryMultiplyLong()
		{
			var result = Expression
				.Multiply(
					Expression.Parameter<long>(),
					Expression.Parameter<long>())
				.Compile();
			Assert.AreEqual<long>(4011L, result(1337, 3));
		}

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryMultiplyUShort()
        {
            var result = Expression
                .Multiply(
                    Expression.Parameter<ushort>(),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(22, result(11, 2));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryMultiplyUInteger()
        {
            var result = Expression
                .Multiply(
                    Expression.Parameter<uint>(),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(42, result(21, 2));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryMultiplyULong()
        {
            var result = Expression
                .Multiply(
                    Expression.Parameter<ulong>(),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(4011L, result(1337, 3));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryMultiplyFloat()
        {
            var result = Expression
                .Multiply(
                    Expression.Parameter<float>(),
                    Expression.Parameter<float>())
                .Compile();
            Assert.AreEqual<float>(22.0f, result(11.0f, 2.0f));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryMultiplyDouble()
        {
            var result = Expression
                .Multiply(
                    Expression.Parameter<double>(),
                    Expression.Parameter<double>())
                .Compile();
            Assert.AreEqual<double>(42.0, result(21.0, 2.0));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryMultiplyDecimal()
        {
            var result = Expression
                .Multiply(
                    Expression.Parameter<decimal>(),
                    Expression.Parameter<decimal>())
                .Compile();
            Assert.AreEqual<decimal>(42.0m, result(21.0m, 2.0m));
        }
    }
}