using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryOr
{
	[TestClass]
	public class DoubleParameterBinaryOrTests
	{
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryOrShortNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<short>(),
                    Expression.Parameter<short>())
                .Compile();
            Assert.AreEqual<short>(0b01011, result(0b01001, 0b01010));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryOrShortEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<int>(),
                    Expression.Parameter<int>())
                .Compile();
            Assert.AreEqual<int>(0, result(0b0, 0b0));
        }

        [TestMethod]
		[TestCategory(TestConstants.BinaryOr)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void DoubleParameterBinaryOrIntNonEmpty()
		{
			var result = Expression
				.Or(
					Expression.Parameter<int>(),
					Expression.Parameter<int>())
				.Compile();
			Assert.AreEqual<int>(0b01011, result(0b01001, 0b01010));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryOr)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void DoubleParameterBinaryOrIntEmpty()
		{
			var result = Expression
				.Or(
					Expression.Parameter<int>(),
					Expression.Parameter<int>())
				.Compile();
			Assert.AreEqual<int>(0, result(0b0, 0b0));
		}
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryOrLongNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<long>(),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(0b01011, result(0b01001, 0b01010));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryOrLongEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<long>(),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(0, result(0b0, 0b0));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryOrUShortNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<ushort>(),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(0b01011, result(0b01001, 0b01010));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryOrUShortEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<ushort>(),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(0, result(0b0, 0b0));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryOrUIntNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<uint>(),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(0b01011, result(0b01001, 0b01010));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryOrUIntEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<uint>(),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(0, result(0b0, 0b0));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryOrULongNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<ulong>(),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(0b01011, result(0b01001, 0b01010));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryOrULongEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<ulong>(),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(0, result(0b0, 0b0));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryOrByteNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<byte>(),
                    Expression.Parameter<byte>())
                .Compile();
            Assert.AreEqual<byte>(0b01011, result(0b01001, 0b01010));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryOrByteEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<byte>(),
                    Expression.Parameter<byte>())
                .Compile();
            Assert.AreEqual<byte>(0, result(0b0, 0b0));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryOrSbyteNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<sbyte>(),
                    Expression.Parameter<sbyte>())
                .Compile();
            Assert.AreEqual<sbyte>(0b01011, result(0b01001, 0b01010));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryOrSbyteEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<sbyte>(),
                    Expression.Parameter<sbyte>())
                .Compile();
            Assert.AreEqual<sbyte>(0, result(0b0, 0b0));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryOrBoolTrue()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<bool>(),
                    Expression.Parameter<bool>())
                .Compile();
            Assert.AreEqual<bool>(true, result(true, false));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryOrBoolFalse()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<bool>(),
                    Expression.Parameter<bool>())
                .Compile();
            Assert.AreEqual<bool>(false, result(false, false));
        }
    }
}