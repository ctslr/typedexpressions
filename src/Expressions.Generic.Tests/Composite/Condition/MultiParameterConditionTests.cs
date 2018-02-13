using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.Composite.Condition
{
	[TestClass]
	public class MultiParameterConditionTests
	{
		[TestMethod]
		[TestCategory(TestConstants.Condition)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		[TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
		public void ParameterlessConditionOverSingleParameter()
		{
			var innerCondition = Expression.Condition(Expression.Constant(true), Expression.Constant(1), Expression.Parameter<int>());
			Assert.AreEqual<int>(1, innerCondition.Compile()(2), $"Test prerequisite failed");
			var condition = Expression.Condition(Expression.Constant(true), innerCondition, Expression.Constant(4));
			var func = condition.Compile();
			Assert.AreEqual<int>(1, func(5));
            condition = Expression.Condition(Expression.Constant(false), innerCondition, Expression.Constant(4));
            func = condition.Compile();
            Assert.AreEqual<int>(4, func(5));
            innerCondition = Expression.Condition(Expression.Constant(false), Expression.Constant(1), Expression.Parameter<int>());
            Assert.AreEqual<int>(2, innerCondition.Compile()(2), $"Test prerequisite failed");
            condition = Expression.Condition(Expression.Constant(true), Expression.Constant(4), innerCondition);
            func = condition.Compile();
            Assert.AreEqual<int>(4, func(5));
            condition = Expression.Condition(Expression.Constant(false), Expression.Constant(4), innerCondition);
            func = condition.Compile();
            Assert.AreEqual<int>(5, func(5));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void DoubleParameterConditionOverSingleParameter()
        {
            var innerCondition = Expression.Condition(Expression.Constant(true), Expression.Constant(1), Expression.Parameter<int>());
            Assert.AreEqual<int>(1, innerCondition.Compile()(2), $"Test prerequisite failed");
            var condition = Expression.Condition(Expression.Constant(true), innerCondition, Expression.Parameter<int>());
            var func = condition.Compile();
            Assert.AreEqual<int>(1, func(3, 4));
            condition = Expression.Condition(Expression.Constant(false), innerCondition, Expression.Parameter<int>());
            func = condition.Compile();
            Assert.AreEqual<int>(4, func(3, 4));
            innerCondition = Expression.Condition(Expression.Constant(false), Expression.Constant(1), Expression.Parameter<int>());
            Assert.AreEqual<int>(2, innerCondition.Compile()(2), $"Test prerequisite failed");
            condition = Expression.Condition(Expression.Constant(true), Expression.Parameter<int>(), innerCondition);
            func = condition.Compile();
            Assert.AreEqual<int>(3, func(3, 4));
            condition = Expression.Condition(Expression.Constant(false), Expression.Parameter<int>(), innerCondition);
            func = condition.Compile();
            Assert.AreEqual<int>(4, func(3, 4));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void DoubleParameterConditionOverDoubleParameter()
        {
            var innerCondition = Expression.Condition(Expression.Constant(true), Expression.Parameter<int>(), Expression.Parameter<int>());
            Assert.AreEqual<int>(1, innerCondition.Compile()(1, 2), $"Test prerequisite failed");
            var condition = Expression.Condition(Expression.Constant(true), innerCondition, Expression.Parameter<int>());
            var func = condition.Compile();
            Assert.AreEqual<int>(4, func((4, 5), 6));
            condition = Expression.Condition(Expression.Constant(false), innerCondition, Expression.Parameter<int>());
            func = condition.Compile();
            Assert.AreEqual<int>(6, func((4, 5), 6));
            innerCondition = Expression.Condition(Expression.Constant(false), Expression.Parameter<int>(), Expression.Parameter<int>());
            Assert.AreEqual<int>(2, innerCondition.Compile()(1, 2), $"Test prerequisite failed");
            var condition1 = Expression.Condition(Expression.Constant(true), Expression.Parameter<int>(), innerCondition);
            var func1 = condition1.Compile();
            Assert.AreEqual<int>(4, func1(4, (5, 6)));
            condition1 = Expression.Condition(Expression.Constant(false), Expression.Parameter<int>(), innerCondition);
            func1 = condition1.Compile();
            Assert.AreEqual<int>(6, func1(4, (5, 6)));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void DoubleParameterConditionOverParameterless()
        {
            var innerCondition = Expression.Condition(Expression.Constant(true), Expression.Constant(1), Expression.Constant(2));
            Assert.AreEqual<int>(1, innerCondition.Compile()(), $"Test prerequisite failed");
            var condition = Expression.Condition(Expression.Constant(true), innerCondition, Expression.Parameter<int>());
            var func = condition.Compile();
            Assert.AreEqual<int>(1, func(4));
            condition = Expression.Condition(Expression.Constant(false), innerCondition, Expression.Parameter<int>());
            func = condition.Compile();
            Assert.AreEqual<int>(4, func(4));
            innerCondition = Expression.Condition(Expression.Constant(false), Expression.Constant(1), Expression.Constant(2));
            Assert.AreEqual<int>(2, innerCondition.Compile()(), $"Test prerequisite failed");
            condition = Expression.Condition(Expression.Constant(true), Expression.Parameter<int>(), innerCondition);
            func = condition.Compile();
            Assert.AreEqual<int>(4, func(4));
            condition = Expression.Condition(Expression.Constant(false), Expression.Parameter<int>(), innerCondition);
            func = condition.Compile();
            Assert.AreEqual<int>(2, func(4));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void DoubleParameterConditionOverTwoTimesSelf()
        {
            var innerCondition = Expression.Condition(Expression.Constant(true), Expression.Parameter<int>(), Expression.Parameter<int>());
            Assert.AreEqual<int>(1, innerCondition.Compile()(1, 2), $"Test prerequisite failed");
            var outerCondition = Expression.Condition(Expression.Constant(true), innerCondition, Expression.Parameter<int>());
            Assert.AreEqual<int>(1, outerCondition.Compile()((1, 2), 3), $"Test prerequisite failed");
            var condition = Expression.Condition(Expression.Constant(false), Expression.Parameter<int>(), outerCondition);
            var func = condition.Compile();
            Assert.AreEqual<int>(2, func(1,((2, 3), 4)));
            condition = Expression.Condition(Expression.Constant(true), Expression.Parameter<int>(), outerCondition);
            func = condition.Compile();
            Assert.AreEqual<int>(1, func(1, ((2, 3), 4)));
        }



        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void ParameterlessConditionOverParameterConditionSingleParameter()
        {
            var innerCondition = Expression.Condition(Expression.Parameter<bool>(), Expression.Constant(1), Expression.Parameter<int>());
            Assert.AreEqual<int>(1, innerCondition.Compile()(true, 2), $"Test prerequisite failed");
            var condition = Expression.Condition(Expression.Constant(true), innerCondition, Expression.Constant(4));
            var func = condition.Compile();
            Assert.AreEqual<int>(1, func((true, 5)));
            condition = Expression.Condition(Expression.Constant(false), innerCondition, Expression.Constant(4));
            func = condition.Compile();
            Assert.AreEqual<int>(4, func((true, 5)));
            innerCondition = Expression.Condition(Expression.Parameter<bool>(), Expression.Constant(1), Expression.Parameter<int>());
            Assert.AreEqual<int>(2, innerCondition.Compile()(false, 2), $"Test prerequisite failed");
            condition = Expression.Condition(Expression.Constant(true), Expression.Constant(4), innerCondition);
            func = condition.Compile();
            Assert.AreEqual<int>(4, func((false, 5)));
            condition = Expression.Condition(Expression.Constant(false), Expression.Constant(4), innerCondition);
            func = condition.Compile();
            Assert.AreEqual<int>(5, func((false, 5)));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void DoubleParameterConditionOverParameterConditionSingleParameter()
        {
            var innerCondition = Expression.Condition(Expression.Parameter<bool>(), Expression.Constant(1), Expression.Parameter<int>());
            Assert.AreEqual<int>(1, innerCondition.Compile()(true, 2), $"Test prerequisite failed");
            var condition = Expression.Condition(Expression.Constant(true), innerCondition, Expression.Parameter<int>());
            var func = condition.Compile();
            Assert.AreEqual<int>(1, func((true, 3), 4));
            condition = Expression.Condition(Expression.Constant(false), innerCondition, Expression.Parameter<int>());
            func = condition.Compile();
            Assert.AreEqual<int>(4, func((true, 3), 4));
            innerCondition = Expression.Condition(Expression.Parameter<bool>(), Expression.Constant(1), Expression.Parameter<int>());
            Assert.AreEqual<int>(2, innerCondition.Compile()(false, 2), $"Test prerequisite failed");
            var condition1 = Expression.Condition(Expression.Constant(true), Expression.Parameter<int>(), innerCondition);
            var func1 = condition1.Compile();
            Assert.AreEqual<int>(3, func1(3,(false,  4)));
            condition1 = Expression.Condition(Expression.Constant(false), Expression.Parameter<int>(), innerCondition);
            func1 = condition1.Compile();
            Assert.AreEqual<int>(4, func1(3,(false,  4)));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void DoubleParameterConditionOverParameterConditionDoubleParameter()
        {
            var innerCondition = Expression.Condition(Expression.Parameter<bool>(), Expression.Parameter<int>(), Expression.Parameter<int>());
            Assert.AreEqual<int>(1, innerCondition.Compile()(true, 1, 2), $"Test prerequisite failed");
            var condition = Expression.Condition(Expression.Constant(true), innerCondition, Expression.Parameter<int>());
            var func = condition.Compile();
            Assert.AreEqual<int>(4, func((true, (4, 5)), 6));
            condition = Expression.Condition(Expression.Constant(false), innerCondition, Expression.Parameter<int>());
            func = condition.Compile();
            Assert.AreEqual<int>(6, func((true, (4, 5)), 6));
            innerCondition = Expression.Condition(Expression.Parameter<bool>(), Expression.Parameter<int>(), Expression.Parameter<int>());
            Assert.AreEqual<int>(2, innerCondition.Compile()(false, 1, 2), $"Test prerequisite failed");
            var condition1 = Expression.Condition(Expression.Constant(true), Expression.Parameter<int>(), innerCondition);
            var func1 = condition1.Compile();
            Assert.AreEqual<int>(4, func1(4, (false, (5, 6))));
            condition1 = Expression.Condition(Expression.Constant(false), Expression.Parameter<int>(), innerCondition);
            func1 = condition1.Compile();
            Assert.AreEqual<int>(6, func1(4, (false, (5, 6))));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void DoubleParameterConditionOverParameterConditionParameterless()
        {
            var innerCondition = Expression.Condition(Expression.Parameter<bool>(), Expression.Constant(1), Expression.Constant(2));
            Assert.AreEqual<int>(1, innerCondition.Compile()(true), $"Test prerequisite failed");
            var condition = Expression.Condition(Expression.Constant(true), innerCondition, Expression.Parameter<int>());
            var func = condition.Compile();
            Assert.AreEqual<int>(1, func(true, 4));
            condition = Expression.Condition(Expression.Constant(false), innerCondition, Expression.Parameter<int>());
            func = condition.Compile();
            Assert.AreEqual<int>(4, func(true, 4));
            innerCondition = Expression.Condition(Expression.Parameter<bool>(), Expression.Constant(1), Expression.Constant(2));
            Assert.AreEqual<int>(2, innerCondition.Compile()(false), $"Test prerequisite failed");
            var condition1 = Expression.Condition(Expression.Constant(true), Expression.Parameter<int>(), innerCondition);
            var func1 = condition1.Compile();
            Assert.AreEqual<int>(4, func1(4,false));
            condition1 = Expression.Condition(Expression.Constant(false), Expression.Parameter<int>(), innerCondition);
            func1 = condition1.Compile();
            Assert.AreEqual<int>(2, func1(4, false));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void DoubleParameterConditionOverParameterConditionTwoTimesSelf()
        {
            var innerCondition = Expression.Condition(Expression.Parameter<bool>(), Expression.Parameter<int>(), Expression.Parameter<int>());
            Assert.AreEqual<int>(1, innerCondition.Compile()(true, 1, 2), $"Test prerequisite failed");
            var outerCondition = Expression.Condition(Expression.Constant(true), innerCondition, Expression.Parameter<int>());
            Assert.AreEqual<int>(1, outerCondition.Compile()((true, (1, 2)), 3), $"Test prerequisite failed");
            var condition = Expression.Condition(Expression.Constant(false), Expression.Parameter<int>(), outerCondition);
            var func = condition.Compile();
            Assert.AreEqual<int>(2, func(1, ((true, (2, 3)), 4)));
            condition = Expression.Condition(Expression.Constant(true), Expression.Parameter<int>(), outerCondition);
            func = condition.Compile();
            Assert.AreEqual<int>(1, func(1, ((true, (2, 3)), 4)));
        }

        [TestMethod]
        [TestCategory(TestConstants.Condition)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        [TestProperty(TestConstants.Type, TestConstants.ClientComposite)]
        public void AllParameterConditionOverAllParameter()
        {
            var innerCondition = Expression.Condition(Expression.Parameter<bool>(), Expression.Parameter<int>(), Expression.Parameter<int>());
            Assert.AreEqual<int>(1, innerCondition.Compile()(true,1, 2), $"Test prerequisite failed");
            Assert.AreEqual<int>(2, innerCondition.Compile()(false, 1, 2), $"Test prerequisite failed");
            var condition = Expression.Condition(Expression.Parameter<bool>(), innerCondition, Expression.Parameter<int>());
            var func = condition.Compile();
            Assert.AreEqual<int>(4, func(true, (true, (4, 5)), 6));
            Assert.AreEqual<int>(6, func(false, (true, (4, 5)), 6));
            var condition1 = Expression.Condition(Expression.Parameter<bool>(), Expression.Parameter<int>(), innerCondition);
            var func1 = condition1.Compile();
            Assert.AreEqual<int>(4, func1(true, 4, (false, (5, 6))));
            Assert.AreEqual<int>(6, func1(false, 4, (false, (5, 6))));
        }

    }
}