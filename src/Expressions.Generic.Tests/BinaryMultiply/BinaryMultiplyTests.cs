using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryMultiply
{
	[TestClass]
	public class BinaryMultiplyTests
	{
        public void BinaryMultiplyTypeInferred<T>(T constValue) where T : struct
        {
            var type1 = Expression.Multiply(Expression.Constant(constValue), Expression.Constant(constValue)).Compile().GetType();
            Assert.AreEqual(typeof(Func<T>), type1);
            var type2 = Expression.Multiply(Expression.Parameter<T>(), Expression.Constant(constValue)).Compile().GetType();
            Assert.AreEqual(typeof(Func<T, T>), type2);
            var type3 = Expression.Multiply(Expression.Constant(constValue), Expression.Parameter<T>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<T, T>), type3);
            var type4 = Expression.Multiply(Expression.Parameter<T>(), Expression.Parameter<T>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<T, T, T>), type4);
        }

        //[TestMethod]
        //[TestCategory(TestConstants.BinaryMultiply)]
        //[TestCategory(TestConstants.Fail)]
        //[TestProperty(TestConstants.Type, TestConstants.Internal)]
        //public void BinaryMultiplyTypeInferredByte()
        //{
        //    BinaryMultiplyTypeInferred<byte>(1);
        //}

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryMultiplyTypeInferredShort()
        {
            BinaryMultiplyTypeInferred<short>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryMultiplyTypeInferredInt()
        {
            BinaryMultiplyTypeInferred<int>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryMultiplyTypeInferredLong()
        {
            BinaryMultiplyTypeInferred<long>(1);
        }

        //[TestMethod]
        //[TestCategory(TestConstants.BinaryMultiply)]
        //[TestCategory(TestConstants.Fail)]
        //[TestProperty(TestConstants.Type, TestConstants.Internal)]
        //public void BinaryMultiplyTypeInferredSByte()
        //{
        //    BinaryMultiplyTypeInferred<sbyte>(1);
        //}

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryMultiplyTypeInferredUShort()
        {
            BinaryMultiplyTypeInferred<ushort>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryMultiplyTypeInferredUInt()
        {
            BinaryMultiplyTypeInferred<uint>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryMultiplyTypeInferredULong()
        {
            BinaryMultiplyTypeInferred<ulong>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryMultiplyTypeInferredDouble()
        {
            BinaryMultiplyTypeInferred<double>(1.0);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryMultiplyTypeInferredFloat()
        {
            BinaryMultiplyTypeInferred<float>(1.0f);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryMultiplyTypeInferredDecimal()
        {
            BinaryMultiplyTypeInferred<decimal>(1.0m);
        }

        //[TestMethod]
        //[TestCategory(TestConstants.BinaryMultiply)]
        //[TestCategory(TestConstants.Fail)]
        //[TestProperty(TestConstants.Type, TestConstants.Internal)]
        //public void BinaryMultiplyTypeInferredBool()
        //{
        //    BinaryMultiplyTypeInferred<bool>(true);
        //}

    }
}