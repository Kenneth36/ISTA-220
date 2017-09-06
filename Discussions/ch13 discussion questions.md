# Chapter 13. Discussion Questions
## Kenneth Clark
### September 5, 2017  

1.  What is an interface as the term is used on object-oriented programming?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   An interface is like a contract in which when a class implements it, the interface guarantees that the class contains the methods specified in the interface.

2.  How do you define an interface?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  Example:  interface IMyInterface

3.  Can an interface have variables, fields, or properties?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  An interface cannot have variables, fields, or properties.

4.  How do you define a method in an interface?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   You declare methods in an interface the same way you do in a class except you never specify an access modifier (such as public, private, or protected).

5.  Can you instantiate an object through an interface?  Why or why not?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   No, you cannot.  The interface doesn’t contain any functionality, only definitions where functionality will be added by classes that implement it.

6.  Using the new keyword, can you declare a reference to an interface?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  No, you cannot use the new to declare a reference to an interface.

7.  Can an object inherit from multiple interfaces?  Can a class implement multiple interfaces?  If so, how can it do so?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** At most, a class can have one base class, but it is not allowed to implement an unlimited number of interfaces.  If a structure or class implements more than one interface, you specify the interfaces as a list separated by a comma.

8.  What does it mean to explicitly implement an interface?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   To explicitly implement an interface is to include the interface name and the method definition. Example:  IMyInterface.UsedToCallAnInt(int i). 

9.  What are the restrictions on interfaces?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  Restrictions on interfaces include:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;             - An interface can never contain any implementation.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;             - An interface is not allowed to inherit from a structure or a class, although an interface can inherit from another surface.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;             - You cannot specify an access modifier for any method.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;             - You cannot next any types (enumerations, classes, structures or interfaces) inside an interface.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;             - You’re not allowed to define any fields in an interface.

10.  What is the difference between an abstract class and an interface?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  An abstract class can use access modifiers like private, protected, public and sealed.  Abstract classes can also define a method as abstract, virtual, override or sealed override.

11.  What is an abstract method?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** An abstract method is just like a virtual method except it doesn’t contain a method body.

12.  What is a sealed class?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** It is a keyword that can be used to prevent a class from being used as a base class.

13.  What is a sealed method?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  A keyword that can be used to declare an individual method in an unsealed class as sealed, which means that the derived class cannot override this method.




