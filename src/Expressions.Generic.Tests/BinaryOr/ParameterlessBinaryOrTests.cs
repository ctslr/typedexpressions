using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryOr
{
	[TestClass]
	public class ConstantlessBinaryOrTests
	{
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrShortNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Constant<short>(0b01001),
                    Expression.Constant<short>(0b01010))
                .Compile();
            Assert.AreEqual<short>(0b01011, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrShortEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Constant<int>(0b0),
                    Expression.Constant<int>(0b0))
                .Compile();
            Assert.AreEqual<int>(0, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrIntNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Constant<int>(0b01001),
                    Expression.Constant<int>(0b01010))
                .Compile();
            Assert.AreEqual<int>(0b01011, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrIntEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Constant<int>(0b0),
                    Expression.Constant<int>(0b0))
                .Compile();
            Assert.AreEqual<int>(0, result());
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrLongNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Constant<long>(0b01001),
                    Expression.Constant<long>(0b01010))
                .Compile();
            Assert.AreEqual<long>(0b01011, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrLongEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Constant<long>(0b0),
                    Expression.Constant<long>(0b0))
                .Compile();
            Assert.AreEqual<long>(0, result());
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrUShortNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Constant<ushort>(0b01001),
                    Expression.Constant<ushort>(0b01010))
                .Compile();
            Assert.AreEqual<ushort>(0b01011, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrUShortEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Constant<ushort>(0b0),
                    Expression.Constant<ushort>(0b0))
                .Compile();
            Assert.AreEqual<ushort>(0, result());
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrUIntNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Constant<uint>(0b01001),
                    Expression.Constant<uint>(0b01010))
                .Compile();
            Assert.AreEqual<uint>(0b01011, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrUIntEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Constant<uint>(0b0),
                    Expression.Constant<uint>(0b0))
                .Compile();
            Assert.AreEqual<uint>(0, result());
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrULongNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Constant<ulong>(0b01001),
                    Expression.Constant<ulong>(0b01010))
                .Compile();
            Assert.AreEqual<ulong>(0b01011, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrULongEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Constant<ulong>(0b0),
                    Expression.Constant<ulong>(0b0))
                .Compile();
            Assert.AreEqual<ulong>(0, result());
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrByteNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Constant<byte>(0b01001),
                    Expression.Constant<byte>(0b01010))
                .Compile();
            Assert.AreEqual<byte>(0b01011, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrByteEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Constant<byte>(0b0),
                    Expression.Constant<byte>(0b0))
                .Compile();
            Assert.AreEqual<byte>(0, result());
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrSbyteNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Constant<sbyte>(0b01001),
                    Expression.Constant<sbyte>(0b01010))
                .Compile();
            Assert.AreEqual<sbyte>(0b01011, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrSbyteEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Constant<sbyte>(0b0),
                    Expression.Constant<sbyte>(0b0))
                .Compile();
            Assert.AreEqual<sbyte>(0, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrBoolTrue()
        {
            var result = Expression
                .Or(
                    Expression.Constant<bool>(true),
                    Expression.Constant<bool>(false))
                .Compile();
            Assert.AreEqual<bool>(true, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryOrBoolFalse()
        {
            var result = Expression
                .Or(
                    Expression.Constant<bool>(false),
                    Expression.Constant<bool>(false))
                .Compile();
            Assert.AreEqual<bool>(false, result());
        }
    }
}