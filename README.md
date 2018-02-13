# Typed Expressions
``` csharp
    var parameter = Expression.Parameter(typeof(int));
    var constant = Expression.Constant(1337.0);
    
    // type mismatch here -- runtime
    var binary = Expression.And(parameter, constant);
    
    // why do I have to explicitly provide lambda types?
    var lambda = Expression.Lambda<Func<int, int>>(binary, parameter);
    
    // and what happends if I provide those incorrectly? Yup, another runtime failure
    var lambda = Expression.Lambda<Func<bool, string>>(binary, parameter);
```
Actually the whole "make a compilable expression" thing doesn't make sence

``` csharp
    var parameter = Expression.Parameter<int>();
    var constant = Expression.Constant(1337);
    
    // can't infer type -- compile time
    var implicitBinary = Expression.And(parameter, Expression.Constant(1337.0));
    // can't cast -- compile time
    var binary0 = Expression.And<int>(parameter, Expression.Constant(1337.0));
    
    var binary = Expression.And(parameter, constant);
    
    // no more lambdas
    var func = binary.Compile();
```