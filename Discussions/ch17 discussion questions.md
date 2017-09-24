# Chapter 17. Discussion Questions
## Kenneth Clark
### September 24, 2017  

1.  What is a type parameter?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** A type parameter is a generic class.

2.  What does a type parameter do?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** It removes the need for casting, and improves the type safety, and reduces the amount of boxing required.

3.  How many type parameters can a generic class have?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** As many as it wants.  It can have an infinity amount.

4.  What is the difference between a generic class and a generalized class?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** A generic class encapsulates operations that are not specific to a particular data type.  A generalized class can consume additional memory and processor time.

5.  What is a constraint?  How do you specify a constraint?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** A constraint limits the type of parameters of generic class to those that implement a particular set of interfaces.  You specify the interface such as “where T :”

6.  What is a generic method?  How do you define a generic method?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** A generic method is a standard base method that you specify the name as generic.  You add a type <T> to the brackets.

7.  What do we mean when we say that a generic type interface is invariant? 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** Invariant means that it can’t vary.  You cannot assign a class of one type to a reference of another type.

8.  What do we mean when we say that a generic type interface is convariant?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** You have to explicitly tell the compiler that it’s “OK”.  This only works with reference types, not value types.

9.  Does covariance work with value types?  Does it work with reference types?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** No, it only works with reference types.

10.  What do we mean when we say that a generic type interface is contravariant? 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** Contravariant means you can go from a parent class to child class. 



















