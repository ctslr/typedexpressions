using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryAnd
{
	[TestClass]
	public class ParameterlessBinaryMultiplyTests
	{
		[TestMethod]
		[TestCategory(TestConstants.BinaryMultiply)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void BinaryMultiplyShort()
		{
			var result = Expression
				.Multiply(
					Expression.Constant((short)5),
					Expression.Constant((short)2))
				.Compile();
			Assert.AreEqual<short>(10, result());
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryMultiply)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void BinaryMultiplyInteger()
		{
			var result = Expression
				.Multiply(
					Expression.Constant(5),
					Expression.Constant(2))
				.Compile();
			Assert.AreEqual<int>(10, result());
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryMultiply)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void BinaryMultiplyLong()
		{
			var result = Expression
				.Multiply(
					Expression.Constant(5L),
					Expression.Constant(2L))
				.Compile();
			Assert.AreEqual<long>(10L, result());
		}

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryMultiplyUShort()
        {
            var result = Expression
                .Multiply(
                    Expression.Constant((ushort)5),
                    Expression.Constant((ushort)2))
                .Compile();
            Assert.AreEqual<ushort>(10, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryMultiplyUInteger()
        {
            var result = Expression
                .Multiply(
                    Expression.Constant<uint>(5),
                    Expression.Constant<uint>(2))
                .Compile();
            Assert.AreEqual<uint>(10, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryMultiplyULong()
        {
            var result = Expression
                .Multiply(
                    Expression.Constant<ulong>(5L),
                    Expression.Constant<ulong>(2L))
                .Compile();
            Assert.AreEqual<ulong>(10L, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryMultiplyFloat()
        {
            var result = Expression
                .Multiply(
                    Expression.Constant(5.0f),
                    Expression.Constant(2.0f))
                .Compile();
            Assert.AreEqual<float>(10.0f, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryMultiplyDouble()
        {
            var result = Expression
                .Multiply(
                    Expression.Constant(5.0),
                    Expression.Constant(2.0))
                .Compile();
            Assert.AreEqual<double>(10.0, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryMultiplyDecimal()
        {
            var result = Expression
                .Multiply(
                    Expression.Constant(5.0m),
                    Expression.Constant(2.0m))
                .Compile();
            Assert.AreEqual<decimal>(10.0m, result());
        }
    }
}