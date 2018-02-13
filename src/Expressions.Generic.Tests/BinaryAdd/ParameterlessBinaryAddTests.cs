using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryAnd
{
	[TestClass]
	public class ParameterlessBinaryAddTests
	{
		[TestMethod]
		[TestCategory(TestConstants.BinaryAdd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void BinaryAddShort()
		{
			var result = Expression
				.Add(
					Expression.Constant((short)1),
					Expression.Constant((short)2))
				.Compile();
			Assert.AreEqual<short>(3, result());
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryAdd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void BinaryAddInteger()
		{
			var result = Expression
				.Add(
					Expression.Constant(1),
					Expression.Constant(2))
				.Compile();
			Assert.AreEqual<int>(3, result());
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryAdd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void BinaryAddLong()
		{
			var result = Expression
				.Add(
					Expression.Constant(1L),
					Expression.Constant(2L))
				.Compile();
			Assert.AreEqual<long>(3L, result());
		}

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAddUShort()
        {
            var result = Expression
                .Add(
                    Expression.Constant((ushort)1),
                    Expression.Constant((ushort)2))
                .Compile();
            Assert.AreEqual<ushort>(3, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAddUInteger()
        {
            var result = Expression
                .Add(
                    Expression.Constant<uint>(1),
                    Expression.Constant<uint>(2))
                .Compile();
            Assert.AreEqual<uint>(3, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAddULong()
        {
            var result = Expression
                .Add(
                    Expression.Constant<ulong>(1L),
                    Expression.Constant<ulong>(2L))
                .Compile();
            Assert.AreEqual<ulong>(3L, result());
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAddFloat()
        {
            var result = Expression
                .Add(
                    Expression.Constant(1.0f),
                    Expression.Constant(2.0f))
                .Compile();
            Assert.AreEqual(3.0f, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAddDouble()
        {
            var result = Expression
                .Add(
                    Expression.Constant(1.0),
                    Expression.Constant(2.0))
                .Compile();
            Assert.AreEqual<double>(3.0, result());
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void BinaryAddDecimal()
        {
            var result = Expression
                .Add(
                    Expression.Constant(1.0m),
                    Expression.Constant(2.0m))
                .Compile();
            Assert.AreEqual<decimal>(3.0m, result());
        }
    }
}