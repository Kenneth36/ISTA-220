# Chapter 14. Discussion Questions
## Kenneth Clark
### September 24, 2017  

1.  What is the difference between a managed resource and an unmanaged resource?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** A managed resource is a class that contains (and must manage) unmanaged resources.  Unmanaged resources are code that isn’t directly part of .NET 

2.  When is memory for an object (reference type) allocated?  When is the memory deallocated?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** Memory is allocated for an object when it is referenced on the heap.  It is deallocated when it is returned back to the heap.

3.  What is a destructor?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** A destructor is a special method that the CLR calls after the reference to an object has disappeared.  It is required to perform tidying up when an object is garbage collected. 

4.  What is the difference in syntax between a constructor and a destructor?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** The syntax for writing a destructor is a tilde (~) followed by the name of the class.

5.  Give some examples of scarce resources.  Why would you want to manage scarce resources?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** Examples of scarce resources are memory, database connections and file handlers.  

6.  What is exception-safe disposal?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** An exception-safe disposal is a method that is always called, regardless of whether there is an exception. 

7.  How do you think the using statement works for resource management?  Give an informal, English language, explanation of how it works.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** The using statement allows for an object to be destroyed whenever it is finished being called. 

8.  What ill effects could result from attempting to dispose of a resource more than once?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** Nothing will happen if disposing of a resource is held more than once

