using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Expressions.Generic.Tests.BinaryAnd
{
	[TestClass]
	public class SingleParameterBinaryAddTests
	{
		[TestMethod]
		[TestCategory(TestConstants.BinaryAdd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void SingleParameterBinaryAddShort()
		{
			var result = Expression
				.Add(
					Expression.Parameter<short>(),
					Expression.Constant((short)1336))
				.Compile();
			Assert.AreEqual<short>(1337, result(1));
            result = Expression
                .Add(
                    Expression.Constant((short)1336),
                    Expression.Parameter<short>())
                .Compile();
            Assert.AreEqual<short>(1337, result(1));
        }

        [TestMethod]
		[TestCategory(TestConstants.BinaryAdd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void SingleParameterBinaryAddInteger()
		{
			var result = Expression
				.Add(
					Expression.Parameter<int>(),
					Expression.Constant(1336))
				.Compile();
			Assert.AreEqual<int>(1337, result(1));
            result = Expression
                .Add(
                    Expression.Constant(1336),
                    Expression.Parameter<int>())
                .Compile();
            Assert.AreEqual<int>(1337, result(1));
        }

        [TestMethod]
		[TestCategory(TestConstants.BinaryAdd)]
		[TestProperty(TestConstants.Type, TestConstants.Client)]
		public void SingleParameterBinaryAddLong()
		{
			var result = Expression
				.Add(
					Expression.Parameter<long>(),
					Expression.Constant(1336L))
				.Compile();
			Assert.AreEqual<long>(1337, result(1));
            result = Expression
                .Add(
                    Expression.Constant(1336L),
                    Expression.Parameter<long>())
                .Compile();
            Assert.AreEqual<long>(1337, result(1));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAddUShort()
        {
            var result = Expression
                .Add(
                    Expression.Parameter<ushort>(),
                    Expression.Constant((ushort)1336))
                .Compile();
            Assert.AreEqual<ushort>(1337, result(1));
            result = Expression
                .Add(
                    Expression.Constant((ushort)1336),
                    Expression.Parameter<ushort>())
                .Compile();
            Assert.AreEqual<ushort>(1337, result(1));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAddUInteger()
        {
            var result = Expression
                .Add(
                    Expression.Parameter<uint>(),
                    Expression.Constant<uint>(1336))
                .Compile();
            Assert.AreEqual<uint>(1337, result(1));
            result = Expression
                .Add(
                    Expression.Constant<uint>(1336),
                    Expression.Parameter<uint>())
                .Compile();
            Assert.AreEqual<uint>(1337, result(1));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAddULong()
        {
            var result = Expression
                .Add(
                    Expression.Parameter<ulong>(),
                    Expression.Constant<ulong>(1336L))
                .Compile();
            Assert.AreEqual<ulong>(1337, result(1));
            result = Expression
                .Add(
                    Expression.Constant<ulong>(1336L),
                    Expression.Parameter<ulong>())
                .Compile();
            Assert.AreEqual<ulong>(1337, result(1));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAddFloat()
        {
            var result = Expression
                .Add(
                    Expression.Parameter<float>(),
                    Expression.Constant(1336.0f))
                .Compile();
            Assert.AreEqual<float>(1337.0f, result(1.0f));
            result = Expression
                .Add(
                    Expression.Constant(1336.0f),
                    Expression.Parameter<float>())
                .Compile();
            Assert.AreEqual<float>(1337.0f, result(1.0f));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAddDouble()
        {
            var result = Expression
                .Add(
                    Expression.Parameter<double>(),
                    Expression.Constant(1336.0))
                .Compile();
            Assert.AreEqual<double>(1337.0, result(1.0));
            result = Expression
                .Add(
                    Expression.Constant(1336.0),
                    Expression.Parameter<double>())
                .Compile();
            Assert.AreEqual<double>(1337.0, result(1.0));
        }

        [TestMethod]
        [TestCategory(TestConstants.BinaryAdd)]
        [TestProperty(TestConstants.Type, TestConstants.Client)]
        public void SingleParameterBinaryAddDecimal()
        {
            var result = Expression
                .Add(
                    Expression.Parameter<decimal>(),
                    Expression.Constant(1336.0m))
                .Compile();
            Assert.AreEqual<decimal>(1337.0m, result(1.0m));
            result = Expression
               .Add(
                   Expression.Constant(1336.0m),
                   Expression.Parameter<decimal>())
               .Compile();
            Assert.AreEqual<decimal>(1337.0m, result(1.0m));
        }
    }
}