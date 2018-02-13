using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryMultiply
{
	[TestClass]
	public class BinaryMultiplyCompositeTests
	{
        //[TestMethod]
        //[TestCategory(TestConstants.BinaryMultiply)]
        //[TestCategory(TestConstants.Fail)]
        //[TestProperty(TestConstants.Type, TestConstants.InternalComposite)]
        //public void BinaryMultiplyTypeCompositeInferredBool()
        //{
        //    var type10 = Expression.Multiply(Expression.Constant(true), Expression.Not(Expression.Constant(true))).Compile().GetType();
        //    Assert.AreEqual(typeof(Func<bool>), type10);
        //    var type11 = Expression.Multiply(Expression.Not(Expression.Constant(true)), Expression.Constant(true)).Compile().GetType();
        //    Assert.AreEqual(typeof(Func<bool>), type11);
        //    var type12 = Expression.Multiply(Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Constant(true))).Compile().GetType();
        //    Assert.AreEqual(typeof(Func<bool>), type12);
        //    var type20 = Expression.Multiply(Expression.Parameter<bool>(), Expression.Not(Expression.Constant(true))).Compile().GetType();
        //    Assert.AreEqual(typeof(Func<bool, bool>), type20);
        //    var type21 = Expression.Multiply(Expression.Not(Expression.Parameter<bool>()), Expression.Constant(true)).Compile().GetType();
        //    Assert.AreEqual(typeof(Func<bool, bool>), type21);
        //    var type22 = Expression.Multiply(Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Constant(true))).Compile().GetType();
        //    Assert.AreEqual(typeof(Func<bool, bool>), type22);
        //    var type30 = Expression.Multiply(Expression.Constant(true), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
        //    Assert.AreEqual(typeof(Func<bool, bool>), type30);
        //    var type31 = Expression.Multiply(Expression.Not(Expression.Constant(true)), Expression.Parameter<bool>()).Compile().GetType();
        //    Assert.AreEqual(typeof(Func<bool, bool>), type31);
        //    var type32 = Expression.Multiply(Expression.Not(Expression.Constant(true)), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
        //    Assert.AreEqual(typeof(Func<bool, bool>), type32);
        //    var type40 = Expression.Multiply(Expression.Parameter<bool>(), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
        //    Assert.AreEqual(typeof(Func<bool, bool, bool>), type40);
        //    var type41 = Expression.Multiply(Expression.Not(Expression.Parameter<bool>()), Expression.Parameter<bool>()).Compile().GetType();
        //    Assert.AreEqual(typeof(Func<bool, bool, bool>), type41);
        //    var type42 = Expression.Multiply(Expression.Not(Expression.Parameter<bool>()), Expression.Not(Expression.Parameter<bool>())).Compile().GetType();
        //    Assert.AreEqual(typeof(Func<bool, bool, bool>), type42);
        //}

        [TestMethod]
        [TestCategory(TestConstants.BinaryMultiply)]
        [TestProperty(TestConstants.Type, TestConstants.InternalComposite)]
        public void BinaryMultiplyTypeCompositeInferredInt()
        {
            var type10 = Expression.Multiply(Expression.Constant(1), Expression.Not(Expression.Constant(1))).Compile().GetType();
            Assert.AreEqual(typeof(Func<int>), type10);
            var type11 = Expression.Multiply(Expression.Not(Expression.Constant(1)), Expression.Constant(1)).Compile().GetType();
            Assert.AreEqual(typeof(Func<int>), type11);
            var type12 = Expression.Multiply(Expression.Not(Expression.Constant(1)), Expression.Not(Expression.Constant(1))).Compile().GetType();
            Assert.AreEqual(typeof(Func<int>), type12);
            var type20 = Expression.Multiply(Expression.Parameter<int>(), Expression.Not(Expression.Constant(1))).Compile().GetType();
            Assert.AreEqual(typeof(Func<int, int>), type20);
            var type21 = Expression.Multiply(Expression.Not(Expression.Parameter<int>()), Expression.Constant(1)).Compile().GetType();
            Assert.AreEqual(typeof(Func<int, int>), type21);
            var type22 = Expression.Multiply(Expression.Not(Expression.Parameter<int>()), Expression.Not(Expression.Constant(1))).Compile().GetType();
            Assert.AreEqual(typeof(Func<int, int>), type22);
            var type30 = Expression.Multiply(Expression.Constant(1), Expression.Not(Expression.Parameter<int>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<int, int>), type30);
            var type31 = Expression.Multiply(Expression.Not(Expression.Constant(1)), Expression.Parameter<int>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<int, int>), type31);
            var type32 = Expression.Multiply(Expression.Not(Expression.Constant(1)), Expression.Not(Expression.Parameter<int>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<int, int>), type32);
            var type40 = Expression.Multiply(Expression.Parameter<int>(), Expression.Not(Expression.Parameter<int>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<int, int, int>), type40);
            var type41 = Expression.Multiply(Expression.Not(Expression.Parameter<int>()), Expression.Parameter<int>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<int, int, int>), type41);
            var type42 = Expression.Multiply(Expression.Not(Expression.Parameter<int>()), Expression.Not(Expression.Parameter<int>())).Compile().GetType();
            Assert.AreEqual(typeof(Func<int, int, int>), type42);
        }
    }
}