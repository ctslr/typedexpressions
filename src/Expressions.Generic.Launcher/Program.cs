using System;
using Native = System.Linq.Expressions;

namespace Expressions.Generic.Launcher
{
	class Program
	{
		static void Main(string[] args)
		{
			var doubleParameter = Expression.Parameter<double>();
			var convert = Expression.ConvertToInt(doubleParameter);
			var increment = Expression.Increment(convert);
			Console.WriteLine(increment.Compile()(13.37));

			Console.WriteLine(Expression.Add(Expression.Constant(10), convert).Compile()(10.1));
			Console.WriteLine(Expression.GreaterThan(Expression.Constant(10), convert).Compile()(9.9));
			Console.WriteLine(Expression.Or(Expression.Constant(false), Expression.Equal(Expression.Parameter<int>(), Expression.Parameter<int>())).Compile()((2, 2)));

			var parameter001 = Expression.Parameter<int>();
			var parameter002 = Expression.Parameter<int>();
			var greaterThan = Expression.GreaterThan(parameter001, parameter002);
			var nya = Expression.Constant(-1);
			var lulz = Expression.Add(
				Expression.Multiply(Expression.Parameter<int>(), Expression.Constant(2)),
				Expression.Parameter<int>());
			var ifThenElse = Expression.Condition(greaterThan, nya, lulz);
			Console.WriteLine(ifThenElse.Compile()((-1, 1), (3, 10)));
			Console.WriteLine(ifThenElse.Compile()((5, 1), (3, 10)));

			var parameter0 = Expression.Parameter<int>();
			var increment0 = Expression.Increment(parameter0);
			var func0 = increment0.Compile();
			Console.WriteLine(func0(1337));

			var parameter01 = Expression.Parameter<int>();
			var parameter02 = Expression.Parameter<int>();
			var add02 = Expression.Add(parameter01, parameter02);
			var increment01 = Expression.Increment(add02);
			var func01 = increment01.Compile();
			Console.WriteLine(func01((1337, -1)));

			var parameter11 = Expression.Parameter<int>();
			var parameter12 = Expression.Parameter<int>();
			var add12 = Expression.Add(parameter11, parameter12);
			var increment11 = Expression.Increment(add12);
			var increment12 = Expression.Increment(increment11);
			var func11 = increment12.Compile();
			Console.WriteLine(func11((1337, -1)));

			var conditionParameter = Expression.And(Expression.Parameter<bool>(), Expression.Parameter<bool>());
			var parameter1 = Expression.Parameter<int>();
			var parameter2 = Expression.Parameter<int>();
			var ifExpression = Expression.Not(parameter1);
			var elseExpression = Expression.Not(parameter2);

			var condition = Expression.Condition(conditionParameter, ifExpression, elseExpression);
			var func = condition.Compile();

			Console.WriteLine(func((true, true), 3, 2));
			Console.WriteLine(func((true, true), 3, 2));

			Console.WriteLine(func((false, true), 3, 2));
			Console.WriteLine(func((false, true), 3, 2));

			var const0 = Expression.Constant(false);
			var const1 = Expression.Constant(42);
			var const2 = Expression.Constant(1337);
			var condition2 = Expression.Condition(const0, const1, const2);
			Console.WriteLine(condition2.Compile()());

			var parameter = Expression.Parameter<bool>();
			var const31 = Expression.Constant(42);
			var const32 = Expression.Constant(1337);
			var condition3 = Expression.Condition(parameter, const31, const32);
			var func3 = condition3.Compile();
			Console.WriteLine(func3(false) + " / " + func3(true));

			var parameter41 = Expression.Parameter<bool>();
			var parameter42 = Expression.Parameter<bool>();
			var or = Expression.Or(parameter41, parameter42);
			var awesomeCondition = Expression.Condition(or, const31, const32);
			var awesomeFunc = awesomeCondition.Compile();
			Console.WriteLine(awesomeFunc((false, false)));
			Console.WriteLine(awesomeFunc((false, true)));
			Console.WriteLine(awesomeFunc((true, false)));
			Console.WriteLine(awesomeFunc((true, true)));

			AwesomeBitwiseAndLeet();


			//BitwiseAndLeet(); // runtime throws
			//InvalidNotType(); // runtime throws
			Console.ReadKey(true);
		}

		static void BitwiseAndLeet()
		{
			var parameter = Native.Expression.Parameter(typeof(int));
			var constant = Native.Expression.Constant(1337.0);
			var binary = Native.Expression.And(parameter, constant); // type mismatch here -- runtime
			var lambda = Native.Expression.Lambda<Func<int, int>>(binary, parameter);
			var func = lambda.Compile();
			Console.WriteLine(func(1337));
			Console.WriteLine(func(1338));
		}

		static void InvalidNotType()
		{
			var constant = Native.Expression.Constant("1024");
			var not = Native.Expression.Not(constant);
			var constant2 = Native.Expression.Constant(1.0);
			var not2 = Native.Expression.Not(constant2);
		}

		static void AwesomeBitwiseAndLeet()
		{
			var parameter = Expression.Parameter<int>();
			var constant = Expression.Constant(1337);

			//can't infer type -- compile time
			//var implicitBinary = Expression.And(parameter, Expression.Constant(1337.0));

			//can't cast -- compile time
			//var binary0 = Expression.And<int>(parameter, Expression.Constant(1337.0));
			var binary = Expression.And(parameter, constant);
			var func = binary.Compile();
			Console.WriteLine(func(1337));
			Console.WriteLine(func(1338));
		}
	}
}
