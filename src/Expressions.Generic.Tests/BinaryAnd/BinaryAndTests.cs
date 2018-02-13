using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryAnd
{
    [TestClass]
    public class BinaryAndTests
    {
        public void BinaryAndTypeInferred<T>(T constValue) where T : struct
        {
            var type1 = Expression.And(Expression.Constant(constValue), Expression.Constant(constValue)).Compile().GetType();
            Assert.AreEqual(typeof(Func<T>), type1);
            var type2 = Expression.And(Expression.Parameter<T>(), Expression.Constant(constValue)).Compile().GetType();
            Assert.AreEqual(typeof(Func<T, T>), type2);
            var type3 = Expression.And(Expression.Constant(constValue), Expression.Parameter<T>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<T, T>), type3);
            var type4 = Expression.And(Expression.Parameter<T>(), Expression.Parameter<T>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<T, T, T>), type4);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAndTypeInferredByte()
        {
            BinaryAndTypeInferred<byte>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAndTypeInferredShort()
        {
            BinaryAndTypeInferred<short>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAndTypeInferredInt()
        {
            BinaryAndTypeInferred<int>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAndTypeInferredLong()
        {
            BinaryAndTypeInferred<long>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAndTypeInferredSByte()
        {
            BinaryAndTypeInferred<sbyte>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAndTypeInferredUShort()
        {
            BinaryAndTypeInferred<ushort>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAndTypeInferredUInt()
        {
            BinaryAndTypeInferred<uint>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAndTypeInferredULong()
        {
            BinaryAndTypeInferred<ulong>(1);
        }

        //[TestMethod]
        //[TestCategory(TestConstants.BinaryAnd)]
        //[TestCategory(TestConstants.Fail)]
        //[TestProperty(TestConstants.Type, TestConstants.Internal)]
        //public void BinaryAndTypeInferredDouble()
        //{
        //    BinaryAndTypeInferred<double>(1.0);
        //}

        //[TestMethod]
        //[TestCategory(TestConstants.BinaryAnd)]
        //[TestCategory(TestConstants.Fail)]
        //[TestProperty(TestConstants.Type, TestConstants.Internal)]
        //public void BinaryAndTypeInferredFloat()
        //{
        //    BinaryAndTypeInferred<float>(1.0f);
        //}

        //[TestMethod]
        //[TestCategory(TestConstants.BinaryAnd)]
        //[TestCategory(TestConstants.Fail)]
        //[TestProperty(TestConstants.Type, TestConstants.Internal)]
        //public void BinaryAndTypeInferredDecimal()
        //{
        //    BinaryAndTypeInferred<decimal>(1.0m);
        //}

        [TestMethod]
        [TestCategory(TestConstants.BinaryAnd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAndTypeInferredBool()
        {
            BinaryAndTypeInferred<bool>(true);
        }
    }
}