using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryOr
{
	[TestClass]
	public class BinaryOrTests
	{
        public void BinaryOrTypeInferred<T>(T constValue) where T : struct
		{
            var type1 = Expression.Or(Expression.Constant(constValue), Expression.Constant(constValue)).Compile().GetType();
            Assert.AreEqual(typeof(Func<T>), type1);
            var type2 = Expression.Or(Expression.Parameter<T>(), Expression.Constant(constValue)).Compile().GetType();
            Assert.AreEqual(typeof(Func<T, T>), type2);
            var type3 = Expression.Or(Expression.Constant(constValue), Expression.Parameter<T>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<T, T>), type3);
            var type4 = Expression.Or(Expression.Parameter<T>(), Expression.Parameter<T>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<T, T, T>), type4);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryOrTypeInferredByte()
        {
            BinaryOrTypeInferred<byte>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryOrTypeInferredShort()
        {
            BinaryOrTypeInferred<short>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryOrTypeInferredInt()
        {
            BinaryOrTypeInferred<int>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryOrTypeInferredLong()
        {
            BinaryOrTypeInferred<long>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryOrTypeInferredSByte()
        {
            BinaryOrTypeInferred<sbyte>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryOrTypeInferredUShort()
        {
            BinaryOrTypeInferred<ushort>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryOrTypeInferredUInt()
        {
            BinaryOrTypeInferred<uint>(1);
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryOrTypeInferredULong()
        {
            BinaryOrTypeInferred<ulong>(1);
        }

        //[TestMethod]
        //[TestCategory(TestConstants.BinaryOr)]
        //[TestCategory(TestConstants.Fail)]
        //[TestProperty(TestConstants.Type, TestConstants.Internal)]
        //public void BinaryOrTypeInferredDouble()
        //{
        //    BinaryOrTypeInferred<double>(1.0);
        //}

        //[TestMethod]
        //[TestCategory(TestConstants.BinaryOr)]
        //[TestCategory(TestConstants.Fail)]
        //[TestProperty(TestConstants.Type, TestConstants.Internal)]
        //public void BinaryOrTypeInferredFloat()
        //{
        //    BinaryOrTypeInferred<float>(1.0f);
        //}

        //[TestMethod]
        //[TestCategory(TestConstants.BinaryOr)]
        //[TestCategory(TestConstants.Fail)]
        //[TestProperty(TestConstants.Type, TestConstants.Internal)]
        //public void BinaryOrTypeInferredDecimal()
        //{
        //    BinaryOrTypeInferred<decimal>(1.0m);
        //}

        [TestMethod]
        [TestCategory(TestConstants.BinaryOr)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void BinaryOrTypeInferredBool()
        {
            BinaryOrTypeInferred<bool>(true);
        }

    }
}