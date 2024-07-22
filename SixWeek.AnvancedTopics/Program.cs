//Expression tress
// using System.Linq.Expressions;
// using System.Reflection.Metadata;

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