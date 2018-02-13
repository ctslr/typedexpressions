using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryOr
{
	[TestClass]
	public class SingleParameterBinaryOrTests
	{
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrShortNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<short>(),
                    Expression.Constant<short>(0b01001))
                .Compile();
            Assert.AreEqual<int>(0b01011, result(0b01010));
            result = Expression
                .Or(
                    Expression.Constant<short>(0b01001),
                    Expression.Parameter<short>())
                .Compile();
            Assert.AreEqual<short>(0b01011, result(0b01010));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrShortEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<short>(),
                    Expression.Constant<short>(0b0))
                .Compile();
            Assert.AreEqual<short>(0, result(0b0));
            result = Expression
                .Or(
                    Expression.Constant<short>(0b0),
                    Expression.Parameter<short>())
                .Compile();
            Assert.AreEqual<short>(0, result(0b0));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrIntNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<int>(),
                    Expression.Constant<int>(0b01001))
                .Compile();
            Assert.AreEqual<int>(0b01011, result(0b01010));
            result = Expression
                .Or(
                    Expression.Constant<int>(0b01001),
                    Expression.Parameter<int>())
                .Compile();
            Assert.AreEqual<int>(0b01011, result(0b01010));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrIntEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<int>(),
                    Expression.Constant<int>(0b0))
                .Compile();
            Assert.AreEqual<int>(0, result(0b0));
            result = Expression
                .Or(
                    Expression.Constant<int>(0b0),
                    Expression.Parameter<int>())
                .Compile();
            Assert.AreEqual<int>(0, result(0b0));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrLongNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<long>(),
                    Expression.Constant<long>(0b01001))
                .Compile();
            Assert.AreEqual<long>(0b01011, result(0b01010));
            result = Expression
                .Or(
                    Expression.Constant<long>(0b01001),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(0b01011, result(0b01010));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrLongEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<long>(),
                    Expression.Constant<long>(0b0))
                .Compile();
            Assert.AreEqual<long>(0, result(0b0));
            result = Expression
                .Or(
                    Expression.Constant<long>(0b0),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(0, result(0b0));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrUShortNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<ushort>(),
                    Expression.Constant<ushort>(0b01001))
                .Compile();
            Assert.AreEqual<ushort>(0b01011, result(0b01010));
            result = Expression
                .Or(
                    Expression.Constant<ushort>(0b01001),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(0b01011, result(0b01010));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrUShortEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<ushort>(),
                    Expression.Constant<ushort>(0b0))
                .Compile();
            Assert.AreEqual<ushort>(0, result(0b0));
            result = Expression
                .Or(
                    Expression.Constant<ushort>(0b0),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(0, result(0b0));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrUIntNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<uint>(),
                    Expression.Constant<uint>(0b01001))
                .Compile();
            Assert.AreEqual<uint>(0b01011, result(0b01010));
            result = Expression
                .Or(
                    Expression.Constant<uint>(0b01001),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(0b01011, result(0b01010));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrUIntEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<uint>(),
                    Expression.Constant<uint>(0b0))
                .Compile();
            Assert.AreEqual<uint>(0, result(0b0));
            result = Expression
                .Or(
                    Expression.Constant<uint>(0b0),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(0, result(0b0));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrULongNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<ulong>(),
                    Expression.Constant<ulong>(0b01001))
                .Compile();
            Assert.AreEqual<ulong>(0b01011, result(0b01010));
            result = Expression
                .Or(
                    Expression.Constant<ulong>(0b01001),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(0b01011, result(0b01010));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrULongEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<ulong>(),
                    Expression.Constant<ulong>(0b0))
                .Compile();
            Assert.AreEqual<ulong>(0, result(0b0));
            result = Expression
                .Or(
                    Expression.Constant<ulong>(0b0),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(0, result(0b0));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrByteNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<byte>(),
                    Expression.Constant<byte>(0b01001))
                .Compile();
            Assert.AreEqual<byte>(0b01011, result(0b01010));
            result = Expression
                .Or(
                    Expression.Constant<byte>(0b01001),
                    Expression.Parameter<byte>())
                .Compile();
            Assert.AreEqual<byte>(0b01011, result(0b01010));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrByteEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<byte>(),
                    Expression.Constant<byte>(0b0))
                .Compile();
            Assert.AreEqual<byte>(0, result(0b0));
            result = Expression
                .Or(
                    Expression.Constant<byte>(0b0),
                    Expression.Parameter<byte>())
                .Compile();
            Assert.AreEqual<byte>(0, result(0b0));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrSByteNonEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<sbyte>(),
                    Expression.Constant<sbyte>(0b01001))
                .Compile();
            Assert.AreEqual<sbyte>(0b01011, result(0b01010));
            result = Expression
                .Or(
                    Expression.Constant<sbyte>(0b01001),
                    Expression.Parameter<sbyte>())
                .Compile();
            Assert.AreEqual<sbyte>(0b01011, result(0b01010));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrSByteEmpty()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<sbyte>(),
                    Expression.Constant<sbyte>(0b0))
                .Compile();
            Assert.AreEqual<sbyte>(0, result(0b0));
            result = Expression
                .Or(
                    Expression.Constant<sbyte>(0b0),
                    Expression.Parameter<sbyte>())
                .Compile();
            Assert.AreEqual<sbyte>(0, result(0b0));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrBoolTrue()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<bool>(),
                    Expression.Constant<bool>(true))
                .Compile();
            Assert.AreEqual<bool>(true, result(false));
            result = Expression
                .Or(
                    Expression.Constant<bool>(true),
                    Expression.Parameter<bool>())
                .Compile();
            Assert.AreEqual<bool>(true, result(false));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryOrBoolFalse()
        {
            var result = Expression
                .Or(
                    Expression.Parameter<bool>(),
                    Expression.Constant<bool>(false))
                .Compile();
            Assert.AreEqual<bool>(false, result(false));
            result = Expression
                .Or(
                    Expression.Constant<bool>(false),
                    Expression.Parameter<bool>())
                .Compile();
            Assert.AreEqual<bool>(false, result(false));
        }
    }
}