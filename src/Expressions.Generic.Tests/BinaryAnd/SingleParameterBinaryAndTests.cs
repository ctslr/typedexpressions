using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryAnd
{
	[TestClass]
	public class SingleParameterBinaryAndTests
	{
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAndShortNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<short>(),
                    Expression.Constant<short>(0b01))
                .Compile();
            Assert.AreEqual<int>(1, result(0b11));
            result = Expression
                .And(
                    Expression.Constant<short>(0b01),
                    Expression.Parameter<short>())
                .Compile();
            Assert.AreEqual<short>(1, result(0b11));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAndShortEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<short>(),
                    Expression.Constant<short>(0b10))
                .Compile();
            Assert.AreEqual<short>(0, result(0b01));
            result = Expression
                .And(
                    Expression.Constant<short>(0b10),
                    Expression.Parameter<short>())
                .Compile();
            Assert.AreEqual<short>(0, result(0b01));
        }

        [TestMethod]
		[TestCategory(TestConstants.BinaryAnd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void SingleParameterBinaryAndIntNonEmpty()
		{
			var result = Expression
				.And(
					Expression.Parameter<int>(),
					Expression.Constant<int>(0b01))
				.Compile();
			Assert.AreEqual<int>(1, result(0b11));
			result = Expression
				.And(
					Expression.Constant<int>(0b01),
					Expression.Parameter<int>())
				.Compile();
			Assert.AreEqual<int>(1, result(0b11));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryAnd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void SingleParameterBinaryAndIntEmpty()
		{
			var result = Expression
				.And(
					Expression.Parameter<int>(),
					Expression.Constant<int>(0b10))
				.Compile();
			Assert.AreEqual<int>(0, result(0b01));
			result = Expression
				.And(
					Expression.Constant<int>(0b10),
					Expression.Parameter<int>())
				.Compile();
			Assert.AreEqual<int>(0, result(0b01));
		}
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAndLongNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<long>(),
                    Expression.Constant<long>(0b01))
                .Compile();
            Assert.AreEqual<long>(1, result(0b11));
            result = Expression
                .And(
                    Expression.Constant<long>(0b01),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(1, result(0b11));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAndLongEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<long>(),
                    Expression.Constant<long>(0b10))
                .Compile();
            Assert.AreEqual<long>(0, result(0b01));
            result = Expression
                .And(
                    Expression.Constant<long>(0b10),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(0, result(0b01));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAndUShortNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<ushort>(),
                    Expression.Constant<ushort>(0b01))
                .Compile();
            Assert.AreEqual<ushort>(1, result(0b11));
            result = Expression
                .And(
                    Expression.Constant<ushort>(0b01),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(1, result(0b11));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAndUShortEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<ushort>(),
                    Expression.Constant<ushort>(0b10))
                .Compile();
            Assert.AreEqual<ushort>(0, result(0b01));
            result = Expression
                .And(
                    Expression.Constant<ushort>(0b10),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(0, result(0b01));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAndUIntNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<uint>(),
                    Expression.Constant<uint>(0b01))
                .Compile();
            Assert.AreEqual<uint>(1, result(0b11));
            result = Expression
                .And(
                    Expression.Constant<uint>(0b01),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(1, result(0b11));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAndUIntEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<uint>(),
                    Expression.Constant<uint>(0b10))
                .Compile();
            Assert.AreEqual<uint>(0, result(0b01));
            result = Expression
                .And(
                    Expression.Constant<uint>(0b10),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(0, result(0b01));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAndULongNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<ulong>(),
                    Expression.Constant<ulong>(0b01))
                .Compile();
            Assert.AreEqual<ulong>(1, result(0b11));
            result = Expression
                .And(
                    Expression.Constant<ulong>(0b01),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(1, result(0b11));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAndULongEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<ulong>(),
                    Expression.Constant<ulong>(0b10))
                .Compile();
            Assert.AreEqual<ulong>(0, result(0b01));
            result = Expression
                .And(
                    Expression.Constant<ulong>(0b10),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(0, result(0b01));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAndByteNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<byte>(),
                    Expression.Constant<byte>(0b01))
                .Compile();
            Assert.AreEqual<byte>(1, result(0b11));
            result = Expression
                .And(
                    Expression.Constant<byte>(0b01),
                    Expression.Parameter<byte>())
                .Compile();
            Assert.AreEqual<byte>(1, result(0b11));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAndByteEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<byte>(),
                    Expression.Constant<byte>(0b10))
                .Compile();
            Assert.AreEqual<byte>(0, result(0b01));
            result = Expression
                .And(
                    Expression.Constant<byte>(0b10),
                    Expression.Parameter<byte>())
                .Compile();
            Assert.AreEqual<byte>(0, result(0b01));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAndSByteNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<sbyte>(),
                    Expression.Constant<sbyte>(0b01))
                .Compile();
            Assert.AreEqual<sbyte>(1, result(0b11));
            result = Expression
                .And(
                    Expression.Constant<sbyte>(0b01),
                    Expression.Parameter<sbyte>())
                .Compile();
            Assert.AreEqual<sbyte>(1, result(0b11));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAndSByteEmpty()
        {
            var result = Expression
                .And(
                    Expression.Parameter<sbyte>(),
                    Expression.Constant<sbyte>(0b10))
                .Compile();
            Assert.AreEqual<sbyte>(0, result(0b01));
            result = Expression
                .And(
                    Expression.Constant<sbyte>(0b10),
                    Expression.Parameter<sbyte>())
                .Compile();
            Assert.AreEqual<sbyte>(0, result(0b01));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAndBoolTrue()
        {
            var result = Expression
                .And(
                    Expression.Parameter<bool>(),
                    Expression.Constant<bool>(true))
                .Compile();
            Assert.AreEqual<bool>(true, result(true));
            result = Expression
                .And(
                    Expression.Constant<bool>(true),
                    Expression.Parameter<bool>())
                .Compile();
            Assert.AreEqual<bool>(true, result(true));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAndBoolFalse()
        {
            var result = Expression
                .And(
                    Expression.Parameter<bool>(),
                    Expression.Constant<bool>(true))
                .Compile();
            Assert.AreEqual<bool>(false, result(false));
            result = Expression
                .And(
                    Expression.Constant<bool>(true),
                    Expression.Parameter<bool>())
                .Compile();
            Assert.AreEqual<bool>(false, result(false));
        }
    }
}