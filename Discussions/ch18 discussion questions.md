# Chapter 18. Discussion Questions
## Kenneth Clark
### September 24, 2017  

1.  You are building a help ticket system.  You want to ensure that the older the ticket, the sooner it will be handled by the team.  For example, a ticket submitted a week ago has a higher priority than a ticked just submitted.  What kind of data structure would you use, and why?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** I would use a Queue<T> List.  It allows for an item to be handled the soonest with a “higher priority”. 

2.   You are building a tracking system for seasonal agricultural farm labor.  The labor requirements vary widely, depending on the season.  Your requirement is that the newest hires are terminated first, and that our more experienced hires are kept longer.  What kind of data structure would you use, and why? 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** I would use a Stack <T> List.  A stack allows for a first in first out approach for the list that is required.

3.  You are building a transaction database.  Your requirement is that the database adds data very quickly, and that deletions, updates, and searches happen infrequently.  In other words, data is typically added in the order in which the transaction occurs.  What kind of data structure would you use, and why?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** I would use a List <T> List.  A list allows for a data base entry to be added quickly and that “deletions, updates, and searches happen infrequently”.   

4.  You are building an analytical database.  Your requirement is that the database handles queries very quickly, but that the data never changes, i.e., there are no inserts, deletions, or updates.  What kind of data structure would you use, and why?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** I would use a Dictionary <TKey, TValue>.  This list handles queries very quickly and the data never changes.

5.  You are building a personnel directory, where searched are performed by last name, first name, middle name.  Where kind of data structure would you use, and why?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** I would use a LinkedList<T> (or a HashSet<T>).  A linked list performs the option for the last name, first name set up required for this directory.

6.  You are building a username/ password database.  Your requirement is that updates happen frequently (when users change their passwords) and that searches (to authenticate users) happen extremely quickly.  What kind of data structure would you use, and why?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** I would use a Dictionary <TKey, TValue>List.  This type of structure will allow for updates to happen frequently and for searches to happen extremely quickly. 

7.  What is a lambda expression?  Give an example.  Why would we use a lambda expression?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** A lambda expression is a nameless inline function.  Here is an example:  “x => x * x”.  It allows for a simple form of an expression.

8.  What is the difference between lambda expressions and anonymous methods?  What are the advantages of each?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** A lambda expression provides a more succinct and natural syntax than anonymous methods.  An anonymous method allows a coder to pass a block of code rather than the name of the method.














