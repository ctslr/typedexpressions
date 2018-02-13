using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryAnd
{
	[TestClass]
	public class DoubleParameterBinaryAndTests
	{
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAndShortNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<short>(),
                    Expression.Parameter<short>())
                .Compile();
            Assert.AreEqual<short>(1, result(0b11, 0b01));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAndShortEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<int>(),
                    Expression.Parameter<int>())
                .Compile();
            Assert.AreEqual<int>(0, result(0b10, 0b01));
        }

        [TestMethod]
		[TestCategory(TestConstants.BinaryAnd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void DoubleParameterBinaryAndIntNonEmpty()
		{
			var result = Expression
				.And(
					Expression.Parameter<int>(),
					Expression.Parameter<int>())
				.Compile();
			Assert.AreEqual<int>(1, result(0b11, 0b01));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryAnd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void DoubleParameterBinaryAndIntEmpty()
		{
			var result = Expression
				.And(
					Expression.Parameter<int>(),
					Expression.Parameter<int>())
				.Compile();
			Assert.AreEqual<int>(0, result(0b10, 0b01));
		}
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAndLongNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<long>(),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(1, result(0b11, 0b01));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAndLongEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<long>(),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(0, result(0b10, 0b01));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAndUShortNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<ushort>(),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(1, result(0b11, 0b01));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAndUShortEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<ushort>(),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(0, result(0b10, 0b01));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAndUIntNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<uint>(),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(1, result(0b11, 0b01));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAndUIntEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<uint>(),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(0, result(0b10, 0b01));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAndULongNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<ulong>(),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(1, result(0b11, 0b01));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAndULongEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<ulong>(),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(0, result(0b10, 0b01));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAndByteNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<byte>(),
                    Expression.Parameter<byte>())
                .Compile();
            Assert.AreEqual<byte>(1, result(0b11, 0b01));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAndByteEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<byte>(),
                    Expression.Parameter<byte>())
                .Compile();
            Assert.AreEqual<byte>(0, result(0b10, 0b01));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAndSbyteNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<sbyte>(),
                    Expression.Parameter<sbyte>())
                .Compile();
            Assert.AreEqual<sbyte>(1, result(0b11, 0b01));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAndSbyteEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<sbyte>(),
                    Expression.Parameter<sbyte>())
                .Compile();
            Assert.AreEqual<sbyte>(0, result(0b10, 0b01));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAndBoolTrue()
        {
            var result = Expression
                .And(
                    Expression.Parameter<bool>(),
                    Expression.Parameter<bool>())
                .Compile();
            Assert.AreEqual<bool>(true, result(true, true));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAndBoolFalse()
        {
            var result = Expression
                .And(
                    Expression.Parameter<bool>(),
                    Expression.Parameter<bool>())
                .Compile();
            Assert.AreEqual<bool>(false, result(true, false));
        }
    }
}