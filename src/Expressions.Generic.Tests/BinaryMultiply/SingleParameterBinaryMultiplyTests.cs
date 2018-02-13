using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryAnd
{
	[TestClass]
	public class SingleParameterBinaryMultiplyTests
	{
		[TestMethod]
		[TestCategory(TestConstants.BinaryMultiply)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void SingleParameterBinaryMultiplyShort()
		{
			var result = Expression
				.Multiply(
					Expression.Parameter<short>(),
					Expression.Constant((short)11))
				.Compile();
			Assert.AreEqual<short>(22, result(2));
            result = Expression
                .Multiply(
                    Expression.Constant((short)11),
                    Expression.Parameter<short>())
                .Compile();
            Assert.AreEqual<short>(22, result(2));
        }

        [TestMethod]
		[TestCategory(TestConstants.BinaryMultiply)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void SingleParameterBinaryMultiplyInteger()
		{
			var result = Expression
				.Multiply(
					Expression.Parameter<int>(),
					Expression.Constant(21))
				.Compile();
			Assert.AreEqual<int>(42, result(2));
            result = Expression
                .Multiply(
                    Expression.Constant(21),
                    Expression.Parameter<int>())
                .Compile();
            Assert.AreEqual<int>(42, result(2));
        }

        [TestMethod]
		[TestCategory(TestConstants.BinaryMultiply)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void SingleParameterBinaryMultiplyLong()
		{
			var result = Expression
				.Multiply(
					Expression.Parameter<long>(),
					Expression.Constant(1337L))
				.Compile();
			Assert.AreEqual<long>(4011L, result(3));
            result = Expression
                .Multiply(
                    Expression.Constant(1337L),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(4011L, result(3));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryMultiplyUShort()
        {
            var result = Expression
                .Multiply(
                    Expression.Parameter<ushort>(),
                    Expression.Constant((ushort)11))
                .Compile();
            Assert.AreEqual<ushort>(22, result(2));
            result = Expression
                .Multiply(
                    Expression.Constant((ushort)11),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(22, result(2));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryMultiplyUInteger()
        {
            var result = Expression
                .Multiply(
                    Expression.Parameter<uint>(),
                    Expression.Constant<uint>(21))
                .Compile();
            Assert.AreEqual<uint>(42, result(2));
            result = Expression
                .Multiply(
                    Expression.Constant<uint>(21),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(42, result(2));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryMultiplyULong()
        {
            var result = Expression
                .Multiply(
                    Expression.Parameter<ulong>(),
                    Expression.Constant<ulong>(1337L))
                .Compile();
            Assert.AreEqual<ulong>(4011L, result(3));
            result = Expression
                .Multiply(
                    Expression.Constant<ulong>(1337L),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(4011L, result(3));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryMultiplyFloat()
        {
            var result = Expression
                .Multiply(
                    Expression.Parameter<float>(),
                    Expression.Constant(11.0f))
                .Compile();
            Assert.AreEqual<float>(22.0f, result(2.0f));
            result = Expression
                .Multiply(
                    Expression.Constant(11.0f),
                    Expression.Parameter<float>())
                .Compile();
            Assert.AreEqual<float>(22.0f, result(2.0f));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryMultiplyDouble()
        {
            var result = Expression
                .Multiply(
                    Expression.Parameter<double>(),
                    Expression.Constant(21.0))
                .Compile();
            Assert.AreEqual<double>(42.0, result(2.0));
            result = Expression
                .Multiply(
                    Expression.Constant(21.0),
                    Expression.Parameter<double>())
                .Compile();
            Assert.AreEqual<double>(42.0, result(2.0));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryMultiplyDecimal()
        {
            var result = Expression
                .Multiply(
                    Expression.Parameter<decimal>(),
                    Expression.Constant(21.0m))
                .Compile();
            Assert.AreEqual<decimal>(42.0m, result(2.0m));
            result = Expression
                .Multiply(
                    Expression.Constant(21.0m),
                    Expression.Parameter<decimal>())
                .Compile();
            Assert.AreEqual<decimal>(42.0m, result(2.0m));
        }
    }
}