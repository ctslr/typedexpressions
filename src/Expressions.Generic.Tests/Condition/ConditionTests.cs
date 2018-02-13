using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.Condition
{
    [TestClass]
    public class ConditionTests
    {
        public void ConditionTypeInferred<T>(T constValue)
        {
			var type1 = Expression.Condition(Expression.Constant(true), Expression.Constant(constValue), Expression.Constant(constValue)).Compile().GetType();
			Assert.AreEqual(typeof(Func<T>), type1);
			var type2 = Expression.Condition(Expression.Constant(true), Expression.Parameter<T>(), Expression.Constant(constValue)).Compile().GetType();
			Assert.AreEqual(typeof(Func<T, T>), type2);
			var type3 = Expression.Condition(Expression.Constant(true), Expression.Constant(constValue), Expression.Parameter<T>()).Compile().GetType();
			Assert.AreEqual(typeof(Func<T, T>), type3);
			var type4 = Expression.Condition(Expression.Constant(true), Expression.Parameter<T>(), Expression.Parameter<T>()).Compile().GetType();
			Assert.AreEqual(typeof(Func<T, T, T>), type4);
			var type5 = Expression.Condition(Expression.Parameter<bool>(), Expression.Constant(constValue), Expression.Constant(constValue)).Compile().GetType();
			Assert.AreEqual(typeof(Func<bool, T>), type5);
			var type6 = Expression.Condition(Expression.Parameter<bool>(), Expression.Parameter<T>(), Expression.Constant(constValue)).Compile().GetType();
			Assert.AreEqual(typeof(Func<bool, T, T>), type6);
			var type7 = Expression.Condition(Expression.Parameter<bool>(), Expression.Constant(constValue), Expression.Parameter<T>()).Compile().GetType();
			Assert.AreEqual(typeof(Func<bool, T, T>), type7);
			var type8 = Expression.Condition(Expression.Parameter<bool>(), Expression.Parameter<T>(), Expression.Parameter<T>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, T, T, T>), type8);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void ConditionTypeInferredByte()
        {
            ConditionTypeInferred<byte>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void ConditionTypeInferredShort()
        {
            ConditionTypeInferred<short>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void ConditionTypeInferredInt()
        {
            ConditionTypeInferred<int>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void ConditionTypeInferredLong()
        {
            ConditionTypeInferred<long>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void ConditionTypeInferredSByte()
        {
            ConditionTypeInferred<sbyte>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void ConditionTypeInferredUShort()
        {
            ConditionTypeInferred<ushort>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void ConditionTypeInferredUInt()
        {
            ConditionTypeInferred<uint>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void ConditionTypeInferredULong()
        {
            ConditionTypeInferred<ulong>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void ConditionTypeInferredDouble()
        {
            ConditionTypeInferred<double>(1.0);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void ConditionTypeInferredFloat()
        {
            ConditionTypeInferred<float>(1.0f);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void ConditionTypeInferredDecimal()
        {
            ConditionTypeInferred<decimal>(1.0m);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void ConditionTypeInferredString()
        {
            ConditionTypeInferred<string>("1");
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void ConditionTypeInferredBool()
        {
            ConditionTypeInferred<bool>(true);
        }
    }
}