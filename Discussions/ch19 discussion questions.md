# Chapter 19. Discussion Questions
## Kenneth Clark
### October 5, 2017  

1.  What is an enumerable collection?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** It is a collection that implements the System.Collections.IEnumberable interface.  

2.  What properties and methods does the IEnumerable interface contain?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** The IEnumerable interface contains a single method called GetEnumerator, which returns an enumerator object that implements the System.Collections.IEnumerator interface.  The enumerator object is used for stepping through the elements of the collection.

3.  What properties and methods does the IEnumerator interface contain?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** The IEnumerator interface specifies the “Current { get; }” property and the “bool MoveNext()” and “void Reset()” methods.

4.  What values does the MoveNext() method return?  What does it do?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** The MoveNext() method moves the pointer (enumerator) down to the first item in a list.  The method returns true if there is another item in the list and false if there isn’t.

5.  What values does the Reset() method return?  What does it do?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** The Reset() method returns the pointer back to the first item in a list.  

6.  Are IEnumerable and IEnumerator type safe?  Why or why not?  If not, how do you implement type safety?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** The IEnumerable and IEnumerator interfaces are both type-safe because they are Generic Enumeration Interfaces, which gets the element in the collection at the current position of the enumerator.  

7.  Why don’t recursive methods retain state when used with data structures like binary trees?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** Because when defining an enumerator you need to remember where you are in the structure so that method calls to the MoveNext method can update the position appropriately.

8.  How do you define an enumerator?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** An enumerator is like a pointer indicating elements in a list.  

9.  What is an iterator?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** An iterator is a method, get accessor or operator that enables you to support foreach iteration in a class or struct without having to implement the entire IEnumerable interface.
It is a block of code that yields an ordered sequence of values.  It is not actually a member of an enumerable class; rather, it specifies the sequence that an enumerator should use for retuning its values.

10.  What does yield do?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** The yield keyword indicates the value that should be returned by each iteration.  It is like calling a temporary halt to the method, passing back a value to the caller.  It takes code and passes back a value to the caller and then waits.





