using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryAnd
{
    [TestClass]
    public class ParameterlessConditionTests
    {
        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionShortFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Constant(true),
                    Expression.Constant((short)1),
                    Expression.Constant((short)2))
                .Compile();
            Assert.AreEqual<short>(1, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionShortSecond()
        {
            var result = Expression
                .Condition(
                    Expression.Constant(false),
                    Expression.Constant((short)1),
                    Expression.Constant((short)2))
                .Compile();
            Assert.AreEqual<short>(2, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionIntegerFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Constant(true),
                    Expression.Constant(1),
                    Expression.Constant(2))
                .Compile();
            Assert.AreEqual<int>(1, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionIntegerSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                   Expression.Constant(1),
                    Expression.Constant(2))
                .Compile();
            Assert.AreEqual<int>(2, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionLongFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Constant(1L),
                    Expression.Constant(2L))
                .Compile();
            Assert.AreEqual<long>(1L, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionLongSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant(1L),
                    Expression.Constant(2L))
                .Compile();
            Assert.AreEqual<long>(2L, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionUShortFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Constant((ushort)1),
                    Expression.Constant((ushort)2))
                .Compile();
            Assert.AreEqual<ushort>(1, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionUShortSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant((ushort)1),
                    Expression.Constant((ushort)2))
                .Compile();
            Assert.AreEqual<ushort>(2, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionUIntegerFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Constant<uint>(1),
                    Expression.Constant<uint>(2))
                .Compile();
            Assert.AreEqual<uint>(1, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionUIntegerSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant<uint>(1),
                    Expression.Constant<uint>(2))
                .Compile();
            Assert.AreEqual<uint>(2, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionULongFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
Expression.Constant<ulong>(1L),
                    Expression.Constant<ulong>(2L))
                .Compile();
            Assert.AreEqual<ulong>(1L, result());
        }
        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionULongSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant<ulong>(1L),
                    Expression.Constant<ulong>(2L))
                .Compile();
            Assert.AreEqual<ulong>(2L, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionFloatFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Constant(1.0f),
                    Expression.Constant(2.0f))
                .Compile();
            Assert.AreEqual(1.0f, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionFloatSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant(1.0f),
                    Expression.Constant(2.0f))
                .Compile();
            Assert.AreEqual(2.0f, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionDoubleFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Constant(1.0),
                    Expression.Constant(2.0))
                .Compile();
            Assert.AreEqual<double>(1.0, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionDoubleSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant(1.0),
                    Expression.Constant(2.0))
                .Compile();
            Assert.AreEqual<double>(2.0, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionDecimalFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Constant(true),
                   Expression.Constant(1.0m),
                    Expression.Constant(2.0m))
                .Compile();
            Assert.AreEqual<decimal>(1.0m, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionDecimalSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant(1.0m),
                    Expression.Constant(2.0m))
                .Compile();
            Assert.AreEqual<decimal>(2.0m, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionByteFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Constant(true),
                   Expression.Constant<byte>(1),
                    Expression.Constant<byte>(2))
                .Compile();
            Assert.AreEqual<byte>(1, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionByteSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant<byte>(1),
                    Expression.Constant<byte>(2))
                .Compile();
            Assert.AreEqual<byte>(2, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionSByteFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Constant(true),
                   Expression.Constant<sbyte>(1),
                    Expression.Constant<sbyte>(2))
                .Compile();
            Assert.AreEqual<sbyte>(1, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionSByteSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant<sbyte>(1),
                    Expression.Constant<sbyte>(2))
                .Compile();
            Assert.AreEqual<sbyte>(2, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionBoolFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Constant(true),
                   Expression.Constant(true),
                    Expression.Constant(false))
                .Compile();
            Assert.AreEqual<bool>(true, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionBoolSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant(true),
                    Expression.Constant(false))
                .Compile();
            Assert.AreEqual<bool>(false, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionStringFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Constant(true),
                   Expression.Constant<string>("1"),
                    Expression.Constant<string>("2"))
                .Compile();
            Assert.AreEqual<string>("1", result());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterlessConditionStringSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant<string>("1"),
                    Expression.Constant<string>("2"))
                .Compile();
            Assert.AreEqual<string>("2", result());
        }
    }
}