# Chapter 2.  Discussion Questions 
## Kenneth Clark
### August 21, 2017 

1.  What is a statement?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   A statement is a command that performs an action, such as calculating a value or displaying a message to a user. 

1.  What is an identifier?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**    An identifier is a name that you use to identify the elements in your programs, such as classes, methods, and variables.

1.  What is a variable?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   A variable is a storage location that holds a value. 

1.  Are primitive types and value types the same thing? See page 177.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   Most of the primitive types built into C# are collectively called value types.

1.  How are arithmetic operators and variable types related?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**    Arithmetic operators and variable types are related because you can use all the arithmetic operators on variable values, depending on the value’s type. For example, all arithmetic operators can be used on value types such as char, int, long, float, double, or decimal.

1. How do you turn an integer into a string?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   You can convert a number into a string by using the method TryParse, which is found on the various numeric types (int, long, float, etc.).

1.  How do you turn a string into an integer?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   You can convert a string into an integer by using the method called Int32.Parse.

1.  What is the difference between precedence and associativity?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   Precedence governs the order in which an expression’s operators are evaluated.  Associativity is the direction (left or right) in which the operands of an operator are evaluated. (Precedence has a vertical concept, associativity has a horizontal concept)

1.  How are the prefix and postfix increment and decrement operators evaluated differently?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**    You can place either of before or after the variable.  Placing the operator symbol before the variable is called the prefix form (“++count” ?increment / “--count“ ? decrement ) of the operator, and using the operator symbol after the variable is called the postfix form (“count++”?increment / “count--“?decrement ).   (increment and decrement either add one or subtract one)

1.  What is string interpolation?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   String interpolation is the process of evaluating a string literal containing one or more placeholder, yielding a result in which the placeholders are replaced with their corresponding values.

1.  What does the var keyword do?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**    The var keyword can be used in place of a type when declaring a variable to allow the compiler to infer the type of the variable.  
