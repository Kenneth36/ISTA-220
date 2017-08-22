# Chapter 6. Discussion Questions 
## Kenneth Clark
### August 21, 2017  

1.  What is an exception?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   A special global variable that checks to see whether a method succeeded.    

2.  What happens in a try block if the program executes without errors?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**    If none of the statements generates an exception in a try block then they all run one after another.

3.  How does the catch mechanism work for unhandled exceptions?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   An OverflowException will be thrown which will not be caught by the FormatException catch handler.  As a result the calling method immediately exists and execution returns to its caller.

4.  What happens in a program if an exception block fails to handle a particular error?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**    The method immediately exits and execution returns to the calling method

5. What is the parent class for all exceptions?  How does this work?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   The parent class for all exceptions is the System Exception Class.  It organizes the list of different exceptions.

6.  How do you determine the type of an error?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   To determine the type of an error you would throw an exception class.

7.  What is the purpose of integer checking?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   To make sure that integer values used in a program does not reach their limits.

8.  What does the finally block do?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  The finally block ensures that a statement is ‘always’ executed.


