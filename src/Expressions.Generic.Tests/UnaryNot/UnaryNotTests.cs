using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Expressions.Generic.Tests.UnaryNot
{
	[TestClass]
	public class UnaryNotTests
	{
		[TestMethod]
		[TestCategory(TestConstants.UnaryNot)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void IntegerUnaryNot()
		{
			var parameter = Expression.Parameter<int>();
			var not = Expression.Not(parameter);
			var func = not.Compile();
			Assert.AreEqual<int>(-1, func(0));
			Assert.AreEqual<int>(-1338, func(1337));
		}

		[TestMethod]
		[TestCategory(TestConstants.UnaryNot)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void BooleanUnaryNot()
		{
			var parameter = Expression.Parameter<bool>();
			var not = Expression.Not(parameter);
			var func = not.Compile();
			Assert.AreEqual<bool>(true, func(false));
			Assert.AreEqual<bool>(false, func(true));
		}

		[TestMethod]
		[TestCategory(TestConstants.UnaryNot)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void BooleanUnaryMultipleNot()
		{
			var constant = Expression.Constant(true);
			var not1 = Expression.Not(constant);
			var not2 = Expression.Not(not1);
			var func = not2.Compile();
			Assert.AreEqual<bool>(true, func());
			var not3 = Expression.Not(not2);
			func = not3.Compile();
			Assert.AreEqual<bool>(false, func());
		}

		[TestMethod]
		[TestCategory(TestConstants.UnaryNot)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void IntegerUnaryMultipleNot()
		{
			var not1 = Expression.Not(Expression.Parameter<int>());
			var not2 = Expression.Not(not1);
			var func = not2.Compile();
			Assert.AreEqual<int>(0, func(0));
			var not3 = Expression.Not(not2);
			func = not3.Compile();
			Assert.AreEqual<int>(-1, func(0));
		}

        [TestMethod]
        [TestCategory(TestConstants.UnaryNot)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void UnaryNotTypeInferredInt()
        {
            var type1 = Expression.Not(Expression.Constant(1)).Compile().GetType();
            Assert.AreEqual(typeof(Func<int>), type1);
            var type2 = Expression.Not(Expression.Parameter<int>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<int, int>), type2);
        }

        [TestMethod]
        [TestCategory(TestConstants.UnaryNot)]
        [TestProperty(TestConstants.Type, TestConstants.Internal)]
        public void UnaryNotTypeInferredBool()
        {
            var type1 = Expression.Not(Expression.Constant(true)).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool>), type1);
            var type2 = Expression.Not(Expression.Parameter<bool>()).Compile().GetType();
            Assert.AreEqual(typeof(Func<bool, bool>), type2);
        }
    }
}
