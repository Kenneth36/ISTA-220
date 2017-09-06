# Chapter 12. Discussion Questions
## Kenneth Clark
### September 5, 2017  

1.  How does inheritance promote the principle of don’t repeat yourself (DRY)?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   It promotes the DRY principle because it helps to avoid repetition.

2.  What is the syntax of a derived class that inherits from a base class?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  class DerivedClass : BaseClass
                                                 {   
                 
                                                 }

3.  Do all user defined types (classes and structs) inherit from some base class? If so, what is it?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   No, inheritance applies only to classes, not structures.  All structures actually inherit from an abstract class named System.ValueType and for classes System.Object.  (Yes, but you cannot define structs from classes).

4.  What happens if you do not have a default constructor in a base class when creating a derived class?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   The compiler automatically generates one for you.

5.  Can you assign a variable of a derived class to another variable of its base class? Why or why not?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  Yes, you can.  The base class is higher up the inheritance hierarchy 

6.  Can you assign a variable of a derived class to another variable of a derived class of its base class?  Why or why not?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** No, you can’t.  The types would be different

7.  Can you assign a variable of a base class to another variable of a derived class?  Why or why not?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  Yes, you can.  You can’t unreservedly assign a variable of a base class to a variable of a derived class without using the as or is operator or by using a cast 

8.  Under what circumstances would you want to use the new keyword when defining a method in a derived class?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  If you want two methods to have the same signature and to turn off the warning message that occurs.

9.  What is a virtual method?  Why would you want to define a virtual method?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  A method that is intended to be overridden. You might want to provide your own version of a method.

10.  What does override do?  Why does it do it?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  It allows for a virtual method to be overwritten.  It does this to declare another implementation of a method.

11.  How do you define an extension type?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  You define it in the static class and specify the type to which it applies as the first parameter to the method, along with the this keyword.

12.  Why do you define an extension type?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  You can extend an existing type (such as a class or a structure) with additional methods. 






