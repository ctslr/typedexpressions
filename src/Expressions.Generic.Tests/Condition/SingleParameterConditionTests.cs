using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryAnd
{
    [TestClass]
    public class SingleParameterConditionTests
    {
        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionShortFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Constant(true),
                    Expression.Parameter<short>(),
                    Expression.Constant((short)2))
                .Compile();
            Assert.AreEqual<short>(1, result(1));
            result = Expression
                .Condition(
                    Expression.Constant(true),
                    Expression.Constant((short)1),
                    Expression.Parameter<short>())
                .Compile();
            Assert.AreEqual<short>(1, result(2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionShortSecond()
        {
            var result = Expression
                .Condition(
                    Expression.Constant(false),
                    Expression.Parameter<short>(),
                    Expression.Constant((short)2))
                .Compile();
            Assert.AreEqual<short>(2, result(1));
            result = Expression
                .Condition(
                    Expression.Constant(false),
                    Expression.Constant((short)1),
                    Expression.Parameter<short>())
                .Compile();
            Assert.AreEqual<short>(2, result(2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionIntegerFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Constant(true),
                    Expression.Parameter<int>(),
                    Expression.Constant(2))
                .Compile();
            Assert.AreEqual<int>(1, result(1));
            result = Expression
                .Condition(
                    Expression.Constant(true),
                    Expression.Constant(1),
                    Expression.Parameter<int>())
                .Compile();
            Assert.AreEqual<int>(1, result(2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionIntegerSecond()
        {
            var result = Expression
                .Condition(
                    Expression.Constant(false),
                    Expression.Parameter<int>(),
                    Expression.Constant(2))
                .Compile();
            Assert.AreEqual<int>(2, result(1));
            result = Expression
                .Condition(
                    Expression.Constant(false),
                    Expression.Constant(1),
                    Expression.Parameter<int>())
                .Compile();
            Assert.AreEqual<int>(2, result(2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionLongFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Parameter<long>(),
                    Expression.Constant(2L))
                .Compile();
            Assert.AreEqual<long>(1L, result(1L));
            result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Constant(1L),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(1L, result(2L));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionLongSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<long>(),
                    Expression.Constant(2L))
                .Compile();
            Assert.AreEqual<long>(2L, result(1L));
            result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant(1L),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(2L, result(2L));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionUShortFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Parameter<ushort>(),
                    Expression.Constant((ushort)2))
                .Compile();
            Assert.AreEqual<ushort>(1, result(1));
            result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Constant((ushort)1),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(1, result(2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionUShortSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<ushort>(),
                    Expression.Constant((ushort)2))
                .Compile();
            Assert.AreEqual<ushort>(2, result(1));
            result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant((ushort)1),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(2, result(2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionUIntegerFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Parameter<uint>(),
                    Expression.Constant<uint>(2))
                .Compile();
            Assert.AreEqual<uint>(1, result(1));
            result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Constant<uint>(1),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(1, result(2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionUIntegerSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<uint>(),
                    Expression.Constant<uint>(2))
                .Compile();
            Assert.AreEqual<uint>(2, result(1));
            result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant<uint>(1),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(2, result(2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionULongFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Parameter<ulong>(),
                    Expression.Constant<ulong>(2L))
                .Compile();
            Assert.AreEqual<ulong>(1L, result(1L));
            result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Constant<ulong>(1L),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(1L, result(2L));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionULongSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<ulong>(),
                    Expression.Constant<ulong>(2L))
                .Compile();
            Assert.AreEqual<ulong>(2L, result(1L));
            result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant<ulong>(1L),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(2L, result(2L));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionFloatFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Parameter<float>(),
                    Expression.Constant(2.0f))
                .Compile();
            Assert.AreEqual(1.0f, result(1.0f));
            result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Constant(1.0f),
                    Expression.Parameter<float>())
                .Compile();
            Assert.AreEqual(1.0f, result(2.0f));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionFloatSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<float>(),
                    Expression.Constant(2.0f))
                .Compile();
            Assert.AreEqual(2.0f, result(1.0f));
            result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant(1.0f),
                    Expression.Parameter<float>())
                .Compile();
            Assert.AreEqual(2.0f, result(2.0f));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionDoubleFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Parameter<double>(),
                    Expression.Constant(2.0))
                .Compile();
            Assert.AreEqual<double>(1.0, result(1.0));
            result = Expression
                .Condition(
                     Expression.Constant(true),
                    Expression.Constant(1.0),
                    Expression.Parameter<double>())
                .Compile();
            Assert.AreEqual<double>(1.0, result(2.0));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionDoubleSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<double>(),
                    Expression.Constant(2.0))
                .Compile();
            Assert.AreEqual<double>(2.0, result(1.0));
            result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant(1.0),
                    Expression.Parameter<double>())
                .Compile();
            Assert.AreEqual<double>(2.0, result(2.0));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionDecimalFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Constant(true),
                    Expression.Parameter<decimal>(),
                    Expression.Constant(2.0m))
                .Compile();
            Assert.AreEqual<decimal>(1.0m, result(1.0m));
            result = Expression
                .Condition(
                    Expression.Constant(true),
                    Expression.Constant(1.0m),
                    Expression.Parameter<decimal>())
                .Compile();
            Assert.AreEqual<decimal>(1.0m, result(2.0m));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionDecimalSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<decimal>(),
                    Expression.Constant(2.0m))
                .Compile();
            Assert.AreEqual<decimal>(2.0m, result(1.0m));
            result = Expression
               .Condition(
                    Expression.Constant(false),
                    Expression.Constant(1.0m),
                    Expression.Parameter<decimal>())
               .Compile();
            Assert.AreEqual<decimal>(2.0m, result(2.0m));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionByteFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Constant(true),
                    Expression.Parameter<byte>(),
                    Expression.Constant<byte>(2))
                .Compile();
            Assert.AreEqual<byte>(1, result(1));
            result = Expression
                .Condition(
                    Expression.Constant(true),
                    Expression.Constant<byte>(1),
                    Expression.Parameter<byte>())
                .Compile();
            Assert.AreEqual<byte>(1, result(2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionByteSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<byte>(),
                    Expression.Constant<byte>(2))
                .Compile();
            Assert.AreEqual<byte>(2, result(1));
            result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant<byte>(1),
                    Expression.Parameter<byte>())
                .Compile();
            Assert.AreEqual<byte>(2, result(2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionSByteFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Constant(true),
                    Expression.Parameter<sbyte>(),
                    Expression.Constant<sbyte>(2))
                .Compile();
            Assert.AreEqual<sbyte>(1, result(1));
            result = Expression
                .Condition(
                    Expression.Constant(true),
                    Expression.Constant<sbyte>(1),
                    Expression.Parameter<sbyte>())
                .Compile();
            Assert.AreEqual<sbyte>(1, result(2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionSByteSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<sbyte>(),
                    Expression.Constant<sbyte>(2))
                .Compile();
            Assert.AreEqual<sbyte>(2, result(1));
            result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant<sbyte>(1),
                    Expression.Parameter<sbyte>())
                .Compile();
            Assert.AreEqual<sbyte>(2, result(2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionBoolFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Constant(true),
                    Expression.Parameter<bool>(),
                    Expression.Constant(false))
                .Compile();
            Assert.AreEqual<bool>(true, result(true));
            result = Expression
                .Condition(
                    Expression.Constant(true),
                    Expression.Constant(true),
                    Expression.Parameter<bool>())
                .Compile();
            Assert.AreEqual<bool>(true, result(false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionBoolSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<bool>(),
                    Expression.Constant(false))
                .Compile();
            Assert.AreEqual<bool>(false, result(true));
            result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant(true),
                    Expression.Parameter<bool>())
                .Compile();
            Assert.AreEqual<bool>(false, result(false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionStringFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Constant(true),
                    Expression.Parameter<string>(),
                    Expression.Constant<string>("2"))
                .Compile();
            Assert.AreEqual<string>("1", result("1"));
            result = Expression
                .Condition(
                    Expression.Constant(true),
                    Expression.Constant<string>("1"),
                    Expression.Parameter<string>())
                .Compile();
            Assert.AreEqual<string>("1", result("2"));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterConditionStringSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Parameter<string>(),
                    Expression.Constant<string>("2"))
                .Compile();
            Assert.AreEqual<string>("2", result("1"));
            result = Expression
                .Condition(
                     Expression.Constant(false),
                    Expression.Constant<string>("1"),
                    Expression.Parameter<string>())
                .Compile();
            Assert.AreEqual<string>("2", result("2"));
        }
    }
}