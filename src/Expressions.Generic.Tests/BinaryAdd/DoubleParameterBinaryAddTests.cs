using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryAnd
{
	[TestClass]
	public class DoubleParameterBinaryAddTests
	{
		[TestMethod]
		[TestCategory(TestConstants.BinaryAdd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void DoubleParameterBinaryAddShort()
		{
			var result = Expression
				.Add(
					Expression.Parameter<short>(),
					Expression.Parameter<short>())
				.Compile();
			Assert.AreEqual<short>(1337, result(1336, 1));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryAdd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void DoubleParameterBinaryAddInteger()
		{
			var result = Expression
				.Add(
					Expression.Parameter<int>(),
					Expression.Parameter<int>())
				.Compile();
			Assert.AreEqual<int>(1337, result(1336, 1));
		}

		[TestMethod]
		[TestCategory(TestConstants.BinaryAdd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void DoubleParameterBinaryAddLong()
		{
			var result = Expression
				.Add(
					Expression.Parameter<long>(),
					Expression.Parameter<long>())
				.Compile();
			Assert.AreEqual<long>(1337L, result(1336, 1));
		}

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAddUShort()
        {
            var result = Expression
                .Add(
                    Expression.Parameter<ushort>(),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(1337, result(1336, 1));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAddUInteger()
        {
            var result = Expression
                .Add(
                    Expression.Parameter<uint>(),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(1337, result(1336, 1));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAddULong()
        {
            var result = Expression
                .Add(
                    Expression.Parameter<ulong>(),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(1337L, result(1336, 1));
        }
        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAddFloat()
        {
            var result = Expression
                .Add(
                    Expression.Parameter<float>(),
                    Expression.Parameter<float>())
                .Compile();
            Assert.AreEqual<float>(1337.0f, result(1336.0f, 1.0f));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAddDouble()
        {
            var result = Expression
                .Add(
                    Expression.Parameter<double>(),
                    Expression.Parameter<double>())
                .Compile();
            Assert.AreEqual<double>(1337.0, result(1336.0, 1.0));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void DoubleParameterBinaryAddDecimal()
        {
            var result = Expression
                .Add(
                    Expression.Parameter<decimal>(),
                    Expression.Parameter<decimal>())
                .Compile();
            Assert.AreEqual<decimal>(1337.0m, result(1336.0m, 1.0m));
        }
    }
}