# Chapter 4.  Discussion Questions 
## Kenneth Clark
### August 21, 2017 

1.  What are all possible values of a Boolean expression?
...**Answer:**   The possible values of a Boolean expression are true, false, 0 and 1.

2.  List eight Boolean operators.
...**Answer:**  
--'&&'  True
--'||'  False
--'=='  Equal to
--'!='  Not equal to
--'<'   Less than
--'<='  Less than or equal to
--'> '  Greater than
--'>='  Greater than or equal to

3.  What are the difference in how short circuiting works for && and ||?
...**Answer:**   If the left operand of the && operator evaluates to false, the result of the entire expression must be false, regardless of the value of the right operand.  If the value of the left operand of the || operator evaluates to true, the result of the entire expression must be true, regardless of the value of the right operand.  

4.  Look at the list of operators. What operator has the highest precedence?  Which has the lowest?
...**Answer:**    The parenthesis ‘()’ operator has the highest precedence and the assignment ‘=’ operator has the lowest precedence.  
	

5.  In an if or else construction using multiple lines of code, what effect does the use of curly braces have?
...**Answer:**    It has the effect of placing the if or else construction into a block to group a sequence of statements instead of just one statement.  

6. In a switch statement, what happens if you omit break?
...**Answer:**   It will generate an error, which prevents execution to fall through to the next label.
 
