using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryAnd
{
    [TestClass]
    public class ParameterConditionSingleParameterConditionTests
    {
        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionShortFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Parameter<short>(),
                    Expression.Constant((short)2))
                .Compile();
            Assert.AreEqual<short>(1, result(true, 1));
            result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Constant((short)1),
                    Expression.Parameter<short>())
                .Compile();
            Assert.AreEqual<short>(1, result(true, 2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionShortSecond()
        {
            var result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Parameter<short>(),
                    Expression.Constant((short)2))
                .Compile();
            Assert.AreEqual<short>(2, result(false, 1));
            result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Constant((short)1),
                    Expression.Parameter<short>())
                .Compile();
            Assert.AreEqual<short>(2, result(false, 2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionIntegerFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Parameter<int>(),
                    Expression.Constant(2))
                .Compile();
            Assert.AreEqual<int>(1, result(true, 1));
            result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Constant(1),
                    Expression.Parameter<int>())
                .Compile();
            Assert.AreEqual<int>(1, result(true, 2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionIntegerSecond()
        {
            var result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Parameter<int>(),
                    Expression.Constant(2))
                .Compile();
            Assert.AreEqual<int>(2, result(false, 1));
            result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Constant(1),
                    Expression.Parameter<int>())
                .Compile();
            Assert.AreEqual<int>(2, result(false, 2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionLongFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<long>(),
                    Expression.Constant(2L))
                .Compile();
            Assert.AreEqual<long>(1L, result(true, 1L));
            result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant(1L),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(1L, result(true, 2L));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionLongSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<long>(),
                    Expression.Constant(2L))
                .Compile();
            Assert.AreEqual<long>(2L, result(false, 1L));
            result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant(1L),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(2L, result(false, 2L));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionUShortFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<ushort>(),
                    Expression.Constant((ushort)2))
                .Compile();
            Assert.AreEqual<ushort>(1, result(true, 1));
            result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant((ushort)1),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(1, result(true, 2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionUShortSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<ushort>(),
                    Expression.Constant((ushort)2))
                .Compile();
            Assert.AreEqual<ushort>(2, result(false, 1));
            result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant((ushort)1),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(2, result(false, 2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionUIntegerFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<uint>(),
                    Expression.Constant<uint>(2))
                .Compile();
            Assert.AreEqual<uint>(1, result(true, 1));
            result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant<uint>(1),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(1, result(true, 2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionUIntegerSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<uint>(),
                    Expression.Constant<uint>(2))
                .Compile();
            Assert.AreEqual<uint>(2, result(false, 1));
            result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant<uint>(1),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(2, result(false, 2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionULongFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<ulong>(),
                    Expression.Constant<ulong>(2L))
                .Compile();
            Assert.AreEqual<ulong>(1L, result(true, 1L));
            result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant<ulong>(1L),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(1L, result(true, 2L));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionULongSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<ulong>(),
                    Expression.Constant<ulong>(2L))
                .Compile();
            Assert.AreEqual<ulong>(2L, result(false, 1L));
            result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant<ulong>(1L),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(2L, result(false, 2L));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionFloatFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<float>(),
                    Expression.Constant(2.0f))
                .Compile();
            Assert.AreEqual(1.0f, result(true, 1.0f));
            result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant(1.0f),
                    Expression.Parameter<float>())
                .Compile();
            Assert.AreEqual(1.0f, result(true, 2.0f));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionFloatSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<float>(),
                    Expression.Constant(2.0f))
                .Compile();
            Assert.AreEqual(2.0f, result(false, 1.0f));
            result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant(1.0f),
                    Expression.Parameter<float>())
                .Compile();
            Assert.AreEqual(2.0f, result(false, 2.0f));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionDoubleFirst()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<double>(),
                    Expression.Constant(2.0))
                .Compile();
            Assert.AreEqual<double>(1.0, result(true, 1.0));
            result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant(1.0),
                    Expression.Parameter<double>())
                .Compile();
            Assert.AreEqual<double>(1.0, result(true, 2.0));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionDoubleSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<double>(),
                    Expression.Constant(2.0))
                .Compile();
            Assert.AreEqual<double>(2.0, result(false, 1.0));
            result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant(1.0),
                    Expression.Parameter<double>())
                .Compile();
            Assert.AreEqual<double>(2.0, result(false, 2.0));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionDecimalFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Parameter<decimal>(),
                    Expression.Constant(2.0m))
                .Compile();
            Assert.AreEqual<decimal>(1.0m, result(true, 1.0m));
            result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Constant(1.0m),
                    Expression.Parameter<decimal>())
                .Compile();
            Assert.AreEqual<decimal>(1.0m, result(true, 2.0m));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionDecimalSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<decimal>(),
                    Expression.Constant(2.0m))
                .Compile();
            Assert.AreEqual<decimal>(2.0m, result(false, 1.0m));
            result = Expression
               .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Constant(1.0m),
                    Expression.Parameter<decimal>())
               .Compile();
            Assert.AreEqual<decimal>(2.0m, result(false, 2.0m));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionByteFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Parameter<byte>(),
                    Expression.Constant<byte>(2))
                .Compile();
            Assert.AreEqual<byte>(1, result(true, 1));
            result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Constant<byte>(1),
                    Expression.Parameter<byte>())
                .Compile();
            Assert.AreEqual<byte>(1, result(true, 2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionByteSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<byte>(),
                    Expression.Constant<byte>(2))
                .Compile();
            Assert.AreEqual<byte>(2, result(false, 1));
            result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant<byte>(1),
                    Expression.Parameter<byte>())
                .Compile();
            Assert.AreEqual<byte>(2, result(false, 2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionSByteFirst()
        {
            var result = Expression
                .Condition(
                      Expression.Parameter<bool>(),
                    Expression.Parameter<sbyte>(),
                    Expression.Constant<sbyte>(2))
                .Compile();
            Assert.AreEqual<sbyte>(1, result(true, 1));
            result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Constant<sbyte>(1),
                    Expression.Parameter<sbyte>())
                .Compile();
            Assert.AreEqual<sbyte>(1, result(true, 2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionSByteSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<sbyte>(),
                    Expression.Constant<sbyte>(2))
                .Compile();
            Assert.AreEqual<sbyte>(2, result(false, 1));
            result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant<sbyte>(1),
                    Expression.Parameter<sbyte>())
                .Compile();
            Assert.AreEqual<sbyte>(2, result(false, 2));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionBoolFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Parameter<bool>(),
                    Expression.Constant(false))
                .Compile();
            Assert.AreEqual<bool>(true, result(true, true));
            result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Constant(true),
                    Expression.Parameter<bool>())
                .Compile();
            Assert.AreEqual<bool>(true, result(true, false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionBoolSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<bool>(),
                    Expression.Constant(false))
                .Compile();
            Assert.AreEqual<bool>(false, result(false, true));
            result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant(true),
                    Expression.Parameter<bool>())
                .Compile();
            Assert.AreEqual<bool>(false, result(false, false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionStringFirst()
        {
            var result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Parameter<string>(),
                    Expression.Constant<string>("2"))
                .Compile();
            Assert.AreEqual<string>("1", result(true, "1"));
            result = Expression
                .Condition(
                    Expression.Parameter<bool>(),
                    Expression.Constant<string>("1"),
                    Expression.Parameter<string>())
                .Compile();
            Assert.AreEqual<string>("1", result(true, "2"));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void ParameterConditionSingleParameterParameterConditionConditionStringSecond()
        {
            var result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Parameter<string>(),
                    Expression.Constant<string>("2"))
                .Compile();
            Assert.AreEqual<string>("2", result(false, "1"));
            result = Expression
                .Condition(
                     Expression.Parameter<bool>(),
                    Expression.Constant<string>("1"),
                    Expression.Parameter<string>())
                .Compile();
            Assert.AreEqual<string>("2", result(false, "2"));
        }
    }
}