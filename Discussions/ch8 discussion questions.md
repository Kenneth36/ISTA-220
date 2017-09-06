# Chapter 8. Discussion Questions
## Kenneth Clark
### September 5, 2017  

1.  What is the difference between deep copy and shallow copy?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   A deep copy occurs when an object is copied along with the objects to which it refers.  A shallow copy is when an object copies the reference but not the referred object.

2.  What is the value of a reference after you declare and initialize it?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   Whatever value you assign it.  

3.  How do you declare a value type?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  You assign a type such as int, float, double, and char to it.  

4.  How do you declare a reference type?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**    You write the words class, interface or delegate in front of a word.

5. Does C# allow you to assign NULL to a value type?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   No, you cannot assign NULL to a value type.

6.  Can you assign a nullable value type to a non-nullable variable of the same type?  Why or why not?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   Yes, you can.  It depends on what you assign to it.

7.  What is the difference between the stack and the heap?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   The stack allocates memory space to objects in a well-defined (limited) manner as suppose to the heap where objects have an indeterminate time frame as to how long they exist.

8.  What does it mean when we say that all classes are specialized types?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**    It returns an object of the type of the elements in the collection of an instance that’s called.

9.  What does ref do?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   It reserves a memory location on to the heap. 

10.  What does out do?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   It causes arguments to be passed by reference.

11.  Describe boxing and unboxing in your own words.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   Boxing is the process of converting a value type to the type object implemented by that value type.  Unboxing is the explicit conversion of the object type to the value type.

12.  What does cast do?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**   A cast invokes the conversion operator from one type to another.
