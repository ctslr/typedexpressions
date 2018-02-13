using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryAnd
{
    [TestClass]
    public class DoubleParameterConditionTests
    {
        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionShortFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Constant(true),
                    Expression.Parameter<short>(),
                    Expression.Parameter<short>())
                .Compile();
            Assert.AreEqual<short>(1, result(1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionShortSecond()
        {
            var result = Expression
                .Condition(
                    Expression.Constant(false),
                    Expression.Parameter<short>(),
                    Expression.Parameter<short>())
                .Compile();
            Assert.AreEqual<short>(2, result(1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionIntegerFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Constant(true),
                    Expression.Parameter<int>(),
                    Expression.Parameter<int>())
                .Compile();
            Assert.AreEqual<int>(1, result(1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionIntegerSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                   Expression.Parameter<int>(),
                    Expression.Parameter<int>())
                .Compile();
            Assert.AreEqual<int>(2, result(1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionLongFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Parameter<long>(),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(1L, result(1L,2L));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionLongSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<long>(),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(2L, result(1L,2L));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionUShortFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Parameter<ushort>(),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(1, result(1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionUShortSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<ushort>(),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(2, result(1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionUIntegerFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Parameter<uint>(),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(1, result(1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionUIntegerSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<uint>(),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(2, result(1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionULongFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Parameter<ulong>(),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(1L, result(1L,2L));
        }
        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionULongSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<ulong>(),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(2L, result(1L,2L));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionFloatFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Parameter<float>(),
                    Expression.Parameter<float>())
                .Compile();
            Assert.AreEqual(1.0f, result(1.0f, 2.0f));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionFloatSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<float>(),
                    Expression.Parameter<float>())
                .Compile();
            Assert.AreEqual(2.0f, result(1.0f, 2.0f));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionDoubleFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Parameter<double>(),
                    Expression.Parameter<double>())
                .Compile();
            Assert.AreEqual<double>(1.0, result(1.0, 2.0));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionDoubleSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<double>(),
                    Expression.Parameter<double>())
                .Compile();
            Assert.AreEqual<double>(2.0, result(1.0, 2.0));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionDecimalFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Constant(true),
                   Expression.Parameter<decimal>(),
                    Expression.Parameter<decimal>())
                .Compile();
            Assert.AreEqual<decimal>(1.0m, result(1.0m, 2.0m));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionDecimalSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<decimal>(),
                    Expression.Parameter<decimal>())
                .Compile();
            Assert.AreEqual<decimal>(2.0m, result(1.0m, 2.0m));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionByteFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Constant(true),
                   Expression.Parameter<byte>(),
                    Expression.Parameter<byte>())
                .Compile();
            Assert.AreEqual<byte>(1, result(1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionByteSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<byte>(),
                    Expression.Parameter<byte>())
                .Compile();
            Assert.AreEqual<byte>(2, result(1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionSByteFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Constant(true),
                   Expression.Parameter<sbyte>(),
                    Expression.Parameter<sbyte>())
                .Compile();
            Assert.AreEqual<sbyte>(1, result(1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionSByteSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<sbyte>(),
                    Expression.Parameter<sbyte>())
                .Compile();
            Assert.AreEqual<sbyte>(2, result(1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionBoolFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Constant(true),
                   Expression.Parameter<bool>(),
                    Expression.Parameter<bool>())
                .Compile();
            Assert.AreEqual<bool>(true, result(true, false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionBoolSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<bool>(),
                    Expression.Parameter<bool>())
                .Compile();
            Assert.AreEqual<bool>(false, result(true, false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionStringFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Constant(true),
                   Expression.Parameter<string>(),
                    Expression.Parameter<string>())
                .Compile();
            Assert.AreEqual<string>("1", result("1","2"));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterConditionStringSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<string>(),
                    Expression.Parameter<string>())
                .Compile();
            Assert.AreEqual<string>("2", result("1","2"));
        }
    }
}