using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryAnd
{
    [TestClass]
    public class ParameterConditionConditionTests
    {
        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionShortFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Constant((short)1),
                    Expression.Constant((short)2))
                .Compile();
            Assert.AreEqual<short>(1, result(true));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionShortSecond()
        {
            var result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Constant((short)1),
                    Expression.Constant((short)2))
                .Compile();
            Assert.AreEqual<short>(2, result(false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionIntegerFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Constant(1),
                    Expression.Constant(2))
                .Compile();
            Assert.AreEqual<int>(1, result(true));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionIntegerSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                   Expression.Constant(1),
                    Expression.Constant(2))
                .Compile();
            Assert.AreEqual<int>(2, result(false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionLongFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant(1L),
                    Expression.Constant(2L))
                .Compile();
            Assert.AreEqual<long>(1L, result(true));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionLongSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant(1L),
                    Expression.Constant(2L))
                .Compile();
            Assert.AreEqual<long>(2L, result(false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionUShortFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant((ushort)1),
                    Expression.Constant((ushort)2))
                .Compile();
            Assert.AreEqual<ushort>(1, result(true));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionUShortSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant((ushort)1),
                    Expression.Constant((ushort)2))
                .Compile();
            Assert.AreEqual<ushort>(2, result(false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionUIntegerFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant<uint>(1),
                    Expression.Constant<uint>(2))
                .Compile();
            Assert.AreEqual<uint>(1, result(true));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionUIntegerSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant<uint>(1),
                    Expression.Constant<uint>(2))
                .Compile();
            Assert.AreEqual<uint>(2, result(false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionULongFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
Expression.Constant<ulong>(1L),
                    Expression.Constant<ulong>(2L))
                .Compile();
            Assert.AreEqual<ulong>(1L, result(true));
        }
        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionULongSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant<ulong>(1L),
                    Expression.Constant<ulong>(2L))
                .Compile();
            Assert.AreEqual<ulong>(2L, result(false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionFloatFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant(1.0f),
                    Expression.Constant(2.0f))
                .Compile();
            Assert.AreEqual(1.0f, result(true));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionFloatSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant(1.0f),
                    Expression.Constant(2.0f))
                .Compile();
            Assert.AreEqual(2.0f, result(false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionDoubleFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant(1.0),
                    Expression.Constant(2.0))
                .Compile();
            Assert.AreEqual<double>(1.0, result(true));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionDoubleSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant(1.0),
                    Expression.Constant(2.0))
                .Compile();
            Assert.AreEqual<double>(2.0, result(false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionDecimalFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Parameter<bool>(),
                   Expression.Constant(1.0m),
                    Expression.Constant(2.0m))
                .Compile();
            Assert.AreEqual<decimal>(1.0m, result(true));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionDecimalSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant(1.0m),
                    Expression.Constant(2.0m))
                .Compile();
            Assert.AreEqual<decimal>(2.0m, result(false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionByteFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Parameter<bool>(),
                   Expression.Constant<byte>(1),
                    Expression.Constant<byte>(2))
                .Compile();
            Assert.AreEqual<byte>(1, result(true));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionByteSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant<byte>(1),
                    Expression.Constant<byte>(2))
                .Compile();
            Assert.AreEqual<byte>(2, result(false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionSByteFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Parameter<bool>(),
                   Expression.Constant<sbyte>(1),
                    Expression.Constant<sbyte>(2))
                .Compile();
            Assert.AreEqual<sbyte>(1, result(true));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionSByteSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant<sbyte>(1),
                    Expression.Constant<sbyte>(2))
                .Compile();
            Assert.AreEqual<sbyte>(2, result(false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionBoolFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Parameter<bool>(),
                   Expression.Constant(true),
                    Expression.Constant(false))
                .Compile();
            Assert.AreEqual<bool>(true, result(true));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionBoolSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant(true),
                    Expression.Constant(false))
                .Compile();
            Assert.AreEqual<bool>(false, result(false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionStringFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Parameter<bool>(),
                   Expression.Constant<string>("1"),
                    Expression.Constant<string>("2"))
                .Compile();
            Assert.AreEqual<string>("1", result(true));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionConditionStringSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant<string>("1"),
                    Expression.Constant<string>("2"))
                .Compile();
            Assert.AreEqual<string>("2", result(false));
        }
    }
}