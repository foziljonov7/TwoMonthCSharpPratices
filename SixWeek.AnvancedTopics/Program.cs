//Expression tress
using System.Linq.Expressions;
using System.Reflection.Metadata;
using SixWeek.AncancedTopics;

//1
// ParameterExpression param = Expression.Parameter(typeof(int), "x");

// BinaryExpression condition = Expression.GreaterThan(param, Expression.Constant(5));

// BinaryExpression ifTrue = Expression.Multiply(param, Expression.Constant(2));

// BinaryExpression ifFalse = Expression.Divide(param, Expression.Constant(2));

// ConditionalExpression conditionalExpression = Expression.Condition(condition, ifTrue, ifFalse);

// Expression<Func<int, int>> expression = Expression.Lambda<Func<int, int>>(conditionalExpression, param);

// Console.WriteLine(expression);

// Func<int, int> function = expression.Compile();

// int res1 = function(4);
// int res2 = function(6);

// Console.WriteLine($"output 1: {res1}\noutput 2: {res2}");

//2
// Expression<Func<int, bool>> expression = num => num < 5;
// Expression<Func<int, bool>> expression1 = num => num % 5 == 0;

// Func<int, bool> func = expression.Compile();
// Func<int, bool> func1 = expression1.Compile();

// Console.WriteLine($"output: {func(4)}");

// Console.WriteLine($"output: {expression.Compile()(4)}");

// Console.WriteLine($"output 1: {func(33)}");

// Console.WriteLine($"output 1: {expression1.Compile()(100)}");

//3
// Console.WriteLine(CreateBoundResource()(5));

// static Func<int, int> CreateBoundResource()
// {
//     Expression<Func<int, int>> expression = (b) => Resource.Argument + b;
//     var res = expression.Compile();
//     return res;
// } 

//4

// Expression<Func<int, int, bool>> expression = (a, b) => a > b;

// Func<int, int, bool> func = expression.Compile();

// Console.WriteLine($"output: {func(4, 5)}");
// Console.WriteLine($"output 1: {func(11, 9)}");

//5
// ParameterExpression param = Expression.Parameter(typeof(int), "b");

// ConstantExpression constant = Expression.Constant(10);

// BinaryExpression body = Expression.Add(param, constant);

// Expression<Func<int, int>> expression = Expression.Lambda<Func<int, int>>(body, param);

// Func<int, int> func = expression.Compile();

// Console.WriteLine(func(5));


// Expression<Func<int, bool>> expression = n => n % 2 == 0;

// Func<int, bool> func = expression.Compile();

// Console.WriteLine($"output: {func(4)}");