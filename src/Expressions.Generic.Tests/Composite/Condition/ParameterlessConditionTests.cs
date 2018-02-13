using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.Composite.Condition
{
	[TestClass]
	public class ParameterlessConditionTests
	{
		[TestMethod]
		[TestCategory(TestConstants.Condition)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void ParameterlessConditionOverSame()
		{
			var innerCondition = Expression.Condition(Expression.Constant(true), Expression.Constant(1), Expression.Constant(2));
			Assert.AreEqual<int>(1, innerCondition.Compile()(), $"Test prerequisite failed");
			var condition = Expression.Condition(Expression.Constant(true), innerCondition, Expression.Constant(3));
			var func = condition.Compile();
			Assert.AreEqual<int>(1, func());
            condition = Expression.Condition(Expression.Constant(false), innerCondition, Expression.Constant(3));
            func = condition.Compile();
            Assert.AreEqual<int>(3, func());
            innerCondition = Expression.Condition(Expression.Constant(false), Expression.Constant(1), Expression.Constant(2));
            Assert.AreEqual<int>(2, innerCondition.Compile()(), $"Test prerequisite failed");
            condition = Expression.Condition(Expression.Constant(true), Expression.Constant(4), innerCondition);
            func = condition.Compile();
            Assert.AreEqual<int>(4, func());
            condition = Expression.Condition(Expression.Constant(false), Expression.Constant(4), innerCondition);
            func = condition.Compile();
            Assert.AreEqual<int>(2, func());
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void ParameterlessConditionOverSameInCondition()
        {
            var innerCondition = Expression.Condition(Expression.Constant(true), Expression.Constant(true), Expression.Constant(false));
            Assert.AreEqual<bool>(true, innerCondition.Compile()(), $"Test prerequisite failed");
            var condition = Expression.Condition(innerCondition, Expression.Constant(1), Expression.Constant(2));
            var func = condition.Compile();
            Assert.AreEqual<int>(1, func());
            innerCondition = Expression.Condition(Expression.Constant(false), Expression.Constant(true), Expression.Constant(false));
            Assert.AreEqual<bool>(false, innerCondition.Compile()(), $"Test prerequisite failed");
            condition = Expression.Condition(innerCondition,Expression.Constant(3), Expression.Constant(4));
            func = condition.Compile();
            Assert.AreEqual<int>(4, func());
        }
    }
}