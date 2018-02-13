using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.Condition
{
    [TestClass]
    public class ConditionCompositeTests
    {
        public void ConditionTypeCompositeInferred<T>(T constValue)
        {
            var type10 = Expression.Condition(Expression.Constant(true), Expression.Constant(true), Expression.Not(Expression.Constant(true))).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool>), type10);
            var type11 = Expression.Condition(Expression.Constant(true), Expression.Not(Expression.Constant(true)), Expression.Constant(true)).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool>), type11);
            var type12 = Expression.Condition(Expression.Constant(true), Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Constant(true))).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool>), type12);
            var type13 = Expression.Condition(Expression.Not(Expression.Constant(true)), Expression.Constant(constValue), Expression.Constant(constValue)).Compile().GetType();
            Assert.AreEqual(typeof(Func<T>), type13);
            var type14 = Expression.Condition(Expression.Not(Expression.Constant(true)), Expression.Constant(true), Expression.Not(Expression.Constant(true))).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool>), type14);
            var type15 = Expression.Condition(Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Constant(true)), Expression.Constant(true)).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool>), type15);
            var type16 = Expression.Condition(Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Constant(true))).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool>), type16);
            var type20 = Expression.Condition(Expression.Constant(true), Expression.Parameter<bool>(), Expression.Not(Expression.Constant(true))).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type20);
            var type21 = Expression.Condition(Expression.Constant(true), Expression.Not(Expression.Parameter<bool>()), Expression.Constant(true)).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type21);
            var type22 = Expression.Condition(Expression.Constant(true), Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Constant(true))).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type22);
            var type23 = Expression.Condition(Expression.Not(Expression.Constant(true)), Expression.Parameter<T>(), Expression.Constant(constValue)).Compile().GetType();
            Assert.AreEqual(typeof(Func<T, T>), type23);
            var type24 = Expression.Condition(Expression.Not(Expression.Constant(true)), Expression.Parameter<bool>(), Expression.Not(Expression.Constant(true))).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type24);
            var type25 = Expression.Condition(Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Parameter<bool>()), Expression.Constant(true)).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type25);
            var type26 = Expression.Condition(Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Constant(true))).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type26);
            var type30 = Expression.Condition(Expression.Constant(true), Expression.Constant(true), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type30);
            var type31 = Expression.Condition(Expression.Constant(true), Expression.Not(Expression.Constant(true)), Expression.Parameter<bool>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type31);
            var type32 = Expression.Condition(Expression.Constant(true), Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type32);
            var type33 = Expression.Condition(Expression.Not(Expression.Constant(true)), Expression.Constant(constValue), Expression.Parameter<T>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<T, T>), type33);
            var type34 = Expression.Condition(Expression.Not(Expression.Constant(true)), Expression.Constant(true), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type34);
            var type35 = Expression.Condition(Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Constant(true)), Expression.Parameter<bool>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type35);
            var type36 = Expression.Condition(Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type36);
            var type40 = Expression.Condition(Expression.Constant(true), Expression.Parameter<bool>(), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type40);
            var type41 = Expression.Condition(Expression.Constant(true), Expression.Not(Expression.Parameter<bool>()), Expression.Parameter<bool>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type41);
            var type42 = Expression.Condition(Expression.Constant(true), Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type42);
            var type43 = Expression.Condition(Expression.Not(Expression.Constant(true)), Expression.Parameter<T>(), Expression.Parameter<T>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<T, T, T>), type43);
            var type44 = Expression.Condition(Expression.Not(Expression.Constant(true)), Expression.Parameter<bool>(), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type44);
            var type45 = Expression.Condition(Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Parameter<bool>()), Expression.Parameter<bool>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type45);
            var type46 = Expression.Condition(Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type46);
            var type50 = Expression.Condition(Expression.Parameter<bool>(), Expression.Constant(true), Expression.Not(Expression.Constant(true))).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type50);
            var type51 = Expression.Condition(Expression.Parameter<bool>(), Expression.Not(Expression.Constant(true)), Expression.Constant(true)).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type51);
            var type52 = Expression.Condition(Expression.Parameter<bool>(), Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Constant(true))).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type52);
            var type53 = Expression.Condition(Expression.Not(Expression.Parameter<bool>()), Expression.Constant(constValue), Expression.Constant(constValue)).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, T>), type53);
            var type54 = Expression.Condition(Expression.Not(Expression.Parameter<bool>()), Expression.Constant(true), Expression.Not(Expression.Constant(true))).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type54);
            var type55 = Expression.Condition(Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Constant(true)), Expression.Constant(true)).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type55);
            var type56 = Expression.Condition(Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Constant(true))).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type56);
            var type60 = Expression.Condition(Expression.Parameter<bool>(), Expression.Parameter<bool>(), Expression.Not(Expression.Constant(true))).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type60);
            var type61 = Expression.Condition(Expression.Parameter<bool>(), Expression.Not(Expression.Parameter<bool>()), Expression.Constant(true)).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type61);
            var type62 = Expression.Condition(Expression.Parameter<bool>(), Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Constant(true))).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type62);
            var type63 = Expression.Condition(Expression.Not(Expression.Parameter<bool>()), Expression.Parameter<T>(), Expression.Constant(constValue)).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, T, T>), type63);
            var type64 = Expression.Condition(Expression.Not(Expression.Parameter<bool>()), Expression.Parameter<bool>(), Expression.Not(Expression.Constant(true))).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type64);
            var type65 = Expression.Condition(Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Parameter<bool>()), Expression.Constant(true)).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type65);
            var type66 = Expression.Condition(Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Constant(true))).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type66);
            var type70 = Expression.Condition(Expression.Parameter<bool>(), Expression.Constant(true), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type70);
            var type71 = Expression.Condition(Expression.Parameter<bool>(), Expression.Not(Expression.Constant(true)), Expression.Parameter<bool>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type71);
            var type72 = Expression.Condition(Expression.Parameter<bool>(), Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type72);
            var type73 = Expression.Condition(Expression.Not(Expression.Parameter<bool>()), Expression.Constant(constValue), Expression.Parameter<T>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, T, T>), type73);
            var type74 = Expression.Condition(Expression.Not(Expression.Parameter<bool>()), Expression.Constant(true), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type74);
            var type75 = Expression.Condition(Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Constant(true)), Expression.Parameter<bool>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type75);
            var type76 = Expression.Condition(Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool>), type76);
            var type80 = Expression.Condition(Expression.Parameter<bool>(), Expression.Parameter<bool>(), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool, bool>), type80);
            var type81 = Expression.Condition(Expression.Parameter<bool>(), Expression.Not(Expression.Parameter<bool>()), Expression.Parameter<bool>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool, bool>), type81);
            var type82 = Expression.Condition(Expression.Parameter<bool>(), Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool, bool>), type82);
            var type83 = Expression.Condition(Expression.Not(Expression.Parameter<bool>()), Expression.Parameter<T>(), Expression.Parameter<T>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, T, T, T>), type83);
            var type84 = Expression.Condition(Expression.Not(Expression.Parameter<bool>()), Expression.Parameter<bool>(), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool, bool>), type84);
            var type85 = Expression.Condition(Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Parameter<bool>()), Expression.Parameter<bool>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool, bool>), type85);
            var type86 = Expression.Condition(Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool, bool, bool>), type86);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.InternalComposite)]
        public void ConditionTypeCompositeInferredByte()
        {
            ConditionTypeCompositeInferred<byte>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.InternalComposite)]
        public void ConditionTypeCompositeInferredShort()
        {
            ConditionTypeCompositeInferred<short>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.InternalComposite)]
        public void ConditionTypeCompositeInferredInt()
        {
            ConditionTypeCompositeInferred<int>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.InternalComposite)]
        public void ConditionTypeCompositeInferredLong()
        {
            ConditionTypeCompositeInferred<long>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.InternalComposite)]
        public void ConditionTypeCompositeInferredSByte()
        {
            ConditionTypeCompositeInferred<sbyte>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.InternalComposite)]
        public void ConditionTypeCompositeInferredUShort()
        {
            ConditionTypeCompositeInferred<ushort>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.InternalComposite)]
        public void ConditionTypeCompositeInferredUInt()
        {
            ConditionTypeCompositeInferred<uint>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.InternalComposite)]
        public void ConditionTypeCompositeInferredULong()
        {
            ConditionTypeCompositeInferred<ulong>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.InternalComposite)]
        public void ConditionTypeCompositeInferredDouble()
        {
            ConditionTypeCompositeInferred<double>(1.0);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.InternalComposite)]
        public void ConditionTypeCompositeInferredFloat()
        {
            ConditionTypeCompositeInferred<float>(1.0f);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.InternalComposite)]
        public void ConditionTypeCompositeInferredDecimal()
        {
            ConditionTypeCompositeInferred<decimal>(1.0m);
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.InternalComposite)]
        public void ConditionTypeCompositeInferredString()
        {
            ConditionTypeCompositeInferred<string>("1");
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.InternalComposite)]
        public void ConditionTypeCompositeInferredBool()
        {
            ConditionTypeCompositeInferred<bool>(true);
        }
    }
}