# Chapter 20. Discussion Questions
## Kenneth Clark
### October 5, 2017  

1.  What is a delegate?  Explain delegates in terms of pointers and reference types.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** A delegate is a reference to a method.  It is an object that refers to a method.  In terms of pointers and reference types, a delegate “delegates” processing to a referenced method when it is invoked.

2.  How do you declare a delegate?  Include a discussion of types, return values, names, and parameter.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** You declare a delegate much like in the same way that you assign an int value to an int variable.  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ex:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public delegate void ProcessBookDelegate (Book book)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; or
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Person match = personnel.Find(p => p.ID ==3);


3.  How do you create instances of delegates and assign values to the instance?  What are the values?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** You simply use the word “delegate” to create an instance of it.  Ex:  public delegate void Word (string message);

4.  How do you invoke a method that has been added to a delegate?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** Provide the name of the method the delegate will wrap.  Once a delegate is instantiated, a method call made to the delegate will be passed by the delegate to the method.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ex:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // Create a method for a delegate
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; public static void DelegateMethod (string message)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; {  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 	System.Console.WriteLine (message);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; }
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; // Instantiate the delegate
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Del handler = DelegteMethod;

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; //Call the delegate
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; handler(“Hello World”);

5.  What is an event?  Why do we have events?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** An event enables a class or object to notify other classes or objects when something of interest occurs.  For example, the user clicks a button or types something in a field

6.  How do you declare events?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** You declare an event in a class intended to act as an event source.  You declare an event similarly to how you declare a field.

7.  How do delegates recognize event subscriptions?  How do you unsubscribe an event from a delegate?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** You subscribe to an event by using the += operator.  You can unsubscribe an event from a delegate by calling the -= operator.

8.  How do you raise an event?  How do you declare code that raises an event?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** You can raise an event by calling it like a method.   You declare code like so…
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ex:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Protected Overridable Sub OnThresholdReached(e As EventArg
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;               RaiseEvent ThresholdReached(Me, e)
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  End Sub

9.  Explain with specificity what happens when an event fires and that event has been attached to a delegate.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** When an event fires, the methods that are subscribed are called in sequence.  It functions exactly like calling a delegate, but with the protection that it cannot be called from outside the class and the subscribed







