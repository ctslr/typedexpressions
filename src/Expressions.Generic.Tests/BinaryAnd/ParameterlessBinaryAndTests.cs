using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryAnd
{
	[TestClass]
	public class ParameterlessBinaryAndTests
	{
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndShortNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Constant<short>(0b11),
                    Expression.Constant<short>(0b01))
                .Compile();
            Assert.AreEqual<short>(1, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndShortEmpty()
        {
            var result = Expression
                .And(
                    Expression.Constant<int>(0b10),
                    Expression.Constant<int>(0b01))
                .Compile();
            Assert.AreEqual<int>(0, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndIntNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Constant<int>(0b11),
                    Expression.Constant<int>(0b01))
                .Compile();
            Assert.AreEqual<int>(1, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndIntEmpty()
        {
            var result = Expression
                .And(
                    Expression.Constant<int>(0b10),
                    Expression.Constant<int>(0b01))
                .Compile();
            Assert.AreEqual<int>(0, result());
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndLongNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Constant<long>(0b11),
                    Expression.Constant<long>(0b01))
                .Compile();
            Assert.AreEqual<long>(1, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndLongEmpty()
        {
            var result = Expression
                .And(
                    Expression.Constant<long>(0b10),
                    Expression.Constant<long>(0b01))
                .Compile();
            Assert.AreEqual<long>(0, result());
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndUShortNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Constant<ushort>(0b11),
                    Expression.Constant<ushort>(0b01))
                .Compile();
            Assert.AreEqual<ushort>(1, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndUShortEmpty()
        {
            var result = Expression
                .And(
                    Expression.Constant<ushort>(0b10),
                    Expression.Constant<ushort>(0b01))
                .Compile();
            Assert.AreEqual<ushort>(0, result());
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndUIntNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Constant<uint>(0b11),
                    Expression.Constant<uint>(0b01))
                .Compile();
            Assert.AreEqual<uint>(1, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndUIntEmpty()
        {
            var result = Expression
                .And(
                    Expression.Constant<uint>(0b10),
                    Expression.Constant<uint>(0b01))
                .Compile();
            Assert.AreEqual<uint>(0, result());
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndULongNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Constant<ulong>(0b11),
                    Expression.Constant<ulong>(0b01))
                .Compile();
            Assert.AreEqual<ulong>(1, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndULongEmpty()
        {
            var result = Expression
                .And(
                    Expression.Constant<ulong>(0b10),
                    Expression.Constant<ulong>(0b01))
                .Compile();
            Assert.AreEqual<ulong>(0, result());
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndByteNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Constant<byte>(0b11),
                    Expression.Constant<byte>(0b01))
                .Compile();
            Assert.AreEqual<byte>(1, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndByteEmpty()
        {
            var result = Expression
                .And(
                    Expression.Constant<byte>(0b10),
                    Expression.Constant<byte>(0b01))
                .Compile();
            Assert.AreEqual<byte>(0, result());
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndSbyteNonEmpty()
        {
            var result = Expression
                .And(
                    Expression.Constant<sbyte>(0b11),
                    Expression.Constant<sbyte>(0b01))
                .Compile();
            Assert.AreEqual<sbyte>(1, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndSbyteEmpty()
        {
            var result = Expression
                .And(
                    Expression.Constant<sbyte>(0b10),
                    Expression.Constant<sbyte>(0b01))
                .Compile();
            Assert.AreEqual<sbyte>(0, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndBoolTrue()
        {
            var result = Expression
                .And(
                    Expression.Constant<bool>(true),
                    Expression.Constant<bool>(true))
                .Compile();
            Assert.AreEqual<bool>(true, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAndBoolFalse()
        {
            var result = Expression
                .And(
                    Expression.Constant<bool>(true),
                    Expression.Constant<bool>(false))
                .Compile();
            Assert.AreEqual<bool>(false, result());
        }
    }
}