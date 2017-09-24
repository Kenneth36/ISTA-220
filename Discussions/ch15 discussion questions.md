# Chapter 15. Discussion Questions
## Kenneth Clark
### September 24, 2017  


1.  What is the difference between a property and a field?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** A property is a cross between a field and a method, it looks a field but acts like a method.  A field is a variable of any type that is declared directly in a class or struct.  A property can be accessed with the same syntax you would use to access a field.
	
2.  What is the difference between a property and a method?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** A property implements accessor methods called getters and setters that specifies statements that allows data to be read and written inside a property.  A method is a code block that contains a series of statements.

3.  What is your understanding of encapsulation?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** Encapsulation enables a group of properties, methods and other members to be considered in an object. 

4.  Some languages are case insensitive, that is, an “a” and an “A” are considered to be the same letter.  C# is case sensitive.  What implications does this have regarding the naming of variables, methods, and other identifiers?  Do you think that the difference in case in the initial character of two different identifiers is sufficient to distinguish them?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** There are instances in C# where you must use upper case and lower case letters when declaring certain identifiers.  This means that a programmer must be aware of what the rules are regarding the declaration of identifiers in order to properly use them.  Yes, I do think that the difference in case is sufficient in order to distinguish between them.  The laws are simple to understand and clear for understanding. 

5.  Give an example that is not in the book of an instance where you might want to use a read-only property. Give an example not in the book of an instance where you might want to use a write-only property.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** You might want to use a read-only property when you might want to utilize data that is outside of a class (i.e. getting information that is being received from one method).  You might want to use a write-only method when you might want to (for example) set a password.

6.  Can you think of a reason why you might ever want to make getters and setters private?  Give an example.  Also, make a case why getters and setters should never be private.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** If you want to secure the access to data such as a password. If a property is declared to be private, you cannot change the accessibility of it and specify the access to be public.  

7.  What are restrictions on the use of properties?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; •	You can assign a value through a property of a structure or class only after the structure or class has been initialized.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; •	You can’t use a property as a ref or an out argument to a method (although you can use a writable field as a ref or an out argument).
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; •	A property can contain at most one get accessor and one set accessor. A property cannot contain other methods, fields, or properties.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; •	The get and set accessors cannot take any parameter.  The data being assigned is passed to the set accessor automatically by using the value variable.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; •	You can’t declare properties by using const.

8.  What is an object initializer?  What is the syntax for an object initializer?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** An object initializer is code that runs on an object after a constructor and can be used to succinctly set any number of fields on the object to specified values. 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Example of syntax:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Triangle tri1 = new Triangle {Side3Length = 15};
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Triangle tri2 = new Triangle {Side1Length = 15, Side3Length = 20}















