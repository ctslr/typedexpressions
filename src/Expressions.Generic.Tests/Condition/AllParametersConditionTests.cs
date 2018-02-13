using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryAnd
{
    [TestClass]
    public class AllParametersConditionTests
    {
        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionShortFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Parameter<short>(),
                    Expression.Parameter<short>())
                .Compile();
            Assert.AreEqual<short>(1, result(true, 1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionShortSecond()
        {
            var result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Parameter<short>(),
                    Expression.Parameter<short>())
                .Compile();
            Assert.AreEqual<short>(2, result(false, 1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionIntegerFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Parameter<int>(),
                    Expression.Parameter<int>())
                .Compile();
            Assert.AreEqual<int>(1, result(true, 1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionIntegerSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                   Expression.Parameter<int>(),
                    Expression.Parameter<int>())
                .Compile();
            Assert.AreEqual<int>(2, result(false, 1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionLongFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<long>(),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(1L, result(true, 1L,2L));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionLongSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<long>(),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(2L, result(false, 1L,2L));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionUShortFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<ushort>(),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(1, result(true, 1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionUShortSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<ushort>(),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(2, result(false, 1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionUIntegerFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<uint>(),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(1, result(true, 1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionUIntegerSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<uint>(),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(2, result(false, 1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionULongFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<ulong>(),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(1L, result(true, 1L,2L));
        }
        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionULongSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<ulong>(),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(2L, result(false, 1L,2L));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionFloatFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<float>(),
                    Expression.Parameter<float>())
                .Compile();
            Assert.AreEqual(1.0f, result(true, 1.0f, 2.0f));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionFloatSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<float>(),
                    Expression.Parameter<float>())
                .Compile();
            Assert.AreEqual(2.0f, result(false, 1.0f, 2.0f));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionDoubleFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<double>(),
                    Expression.Parameter<double>())
                .Compile();
            Assert.AreEqual<double>(1.0, result(true, 1.0, 2.0));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionDoubleSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<double>(),
                    Expression.Parameter<double>())
                .Compile();
            Assert.AreEqual<double>(2.0, result(false, 1.0, 2.0));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionDecimalFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Parameter<bool>(),
                   Expression.Parameter<decimal>(),
                    Expression.Parameter<decimal>())
                .Compile();
            Assert.AreEqual<decimal>(1.0m, result(true, 1.0m, 2.0m));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionDecimalSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<decimal>(),
                    Expression.Parameter<decimal>())
                .Compile();
            Assert.AreEqual<decimal>(2.0m, result(false, 1.0m, 2.0m));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionByteFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Parameter<bool>(),
                   Expression.Parameter<byte>(),
                    Expression.Parameter<byte>())
                .Compile();
            Assert.AreEqual<byte>(1, result(true, 1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionByteSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<byte>(),
                    Expression.Parameter<byte>())
                .Compile();
            Assert.AreEqual<byte>(2, result(false, 1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionSByteFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Parameter<bool>(),
                   Expression.Parameter<sbyte>(),
                    Expression.Parameter<sbyte>())
                .Compile();
            Assert.AreEqual<sbyte>(1, result(true, 1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionSByteSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<sbyte>(),
                    Expression.Parameter<sbyte>())
                .Compile();
            Assert.AreEqual<sbyte>(2, result(false, 1,2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionBoolFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Parameter<bool>(),
                   Expression.Parameter<bool>(),
                    Expression.Parameter<bool>())
                .Compile();
            Assert.AreEqual<bool>(true, result(true, true, false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionBoolSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<bool>(),
                    Expression.Parameter<bool>())
                .Compile();
            Assert.AreEqual<bool>(false, result(false, true, false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionStringFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Parameter<bool>(),
                   Expression.Parameter<string>(),
                    Expression.Parameter<string>())
                .Compile();
            Assert.AreEqual<string>("1", result(true, "1", "2"));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void AllParameterConditionStringSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<string>(),
                    Expression.Parameter<string>())
                .Compile();
            Assert.AreEqual<string>("2", result(false, "1", "2"));
        }
    }
}