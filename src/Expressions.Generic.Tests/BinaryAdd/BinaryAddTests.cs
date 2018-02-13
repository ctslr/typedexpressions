using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryAdd
{
	[TestClass]
	public class BinaryAddTests
	{
        public void BinaryAddTypeInferred<T>(T constValue) where T : struct
        {
            var type1 = Expression.Add(Expression.Constant(constValue), Expression.Constant(constValue)).Compile().GetType();
            Assert.AreEqual(typeof(Func<T>), type1);
            var type2 = Expression.Add(Expression.Parameter<T>(), Expression.Constant(constValue)).Compile().GetType();
            Assert.AreEqual(typeof(Func<T, T>), type2);
            var type3 = Expression.Add(Expression.Constant(constValue), Expression.Parameter<T>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<T, T>), type3);
            var type4 = Expression.Add(Expression.Parameter<T>(), Expression.Parameter<T>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<T, T, T>), type4);
        }

        //[TestMethod]
        //[TestCategory(TestConstants.BinaryAdd)]
        //[TestCategory(TestConstants.Fail)]
        //[TestProperty(TestConstants.Type, TestConstants.Internal)]
        //public void BinaryAddTypeInferredByte()
        //{
        //    BinaryAddTypeInferred<byte>(1);
        //}

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAddTypeInferredShort()
        {
            BinaryAddTypeInferred<short>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAddTypeInferredInt()
        {
            BinaryAddTypeInferred<int>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAddTypeInferredLong()
        {
            BinaryAddTypeInferred<long>(1);
        }

        //[TestMethod]
        //[TestCategory(TestConstants.BinaryAdd)]
        //[TestCategory(TestConstants.Fail)]
        //[TestProperty(TestConstants.Type, TestConstants.Internal)]
        //public void BinaryAddTypeInferredSByte()
        //{
        //    BinaryAddTypeInferred<sbyte>(1);
        //}

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAddTypeInferredUShort()
        {
            BinaryAddTypeInferred<ushort>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAddTypeInferredUInt()
        {
            BinaryAddTypeInferred<uint>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAddTypeInferredULong()
        {
            BinaryAddTypeInferred<ulong>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAddTypeInferredDouble()
        {
            BinaryAddTypeInferred<double>(1.0);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAddTypeInferredFloat()
        {
            BinaryAddTypeInferred<float>(1.0f);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryAddTypeInferredDecimal()
        {
            BinaryAddTypeInferred<decimal>(1.0m);
        }

        //[TestMethod]
        //[TestCategory(TestConstants.BinaryAdd)]
        //[TestCategory(TestConstants.Fail)]
        //[TestProperty(TestConstants.Type, TestConstants.Internal)]
        //public void BinaryAddTypeInferredBool()
        //{
        //    BinaryAddTypeInferred<bool>(true);
        //}

    }
}