# Chapter 10. Discussion Questions
## Kenneth Clark
### September 5, 2017  


1.  What does an array look like in memory?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  It looks like a block of spaces that are next together in sequence that can be accessed using an index. 

2.  Where is memory allocated to hold an array, on the stack or on the heap?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** The memory allocated to hold an array is on the heap because it is a reference type.

3.  Where is memory allocated to hold an array reference, on the stack or on the heap?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  The memory allocated to hold an array reference is on the stack.  

4.  Can an array hold values of different types?  This is a trick question, the answer is, “It depends.”

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  Yes, depending on the reference type declared for the array.

5.  Describe the syntax of the condition or a foreach loop.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  A foreach loop automatically acquires the value of each element in the array, which iterates through the entire array.

6.  How do you make a deep copy of an array?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  You must use appropriate code in a for loop.

7.  What is the difference between a multi-dimensional array and an array of arrays?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** A multi-dimensional array can consume a lot of memory, which allocates memory for unused elements in an array. An array of arrays (also known as a jagged array) is an array in which each column has a different length which allows no space to be allocated for elements that an application is not going to use.

8.  How do you “flatten” a multidimensional array?  In other words, take something that looks like a matrix [ 14  25  36,  7  8  9 ] and turn it into an array [1,2,3,4,5,6,7,8,9]?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  You can create an extension function such as the SelectMany method provided by the namespace System.Linq (Language-Integrated Query (LINQ)). How to make a deep copy:

for(i=0; i<4; i++)
{ 
for(j=0; j<3; j++)
{
uri[i * 4 + j] = Toni[i,j];
}
}
or 

foreach (int i in Toni)
{
int count = 0;
Uri[count] = i;
count++;
}







