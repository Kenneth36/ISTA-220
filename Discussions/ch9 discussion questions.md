# Chapter 9. Discussion Questions
## Kenneth Clark
### September 5, 2017  

1.  Declare an enum for military ranks, either officer or enlisted.  Name it Ranks.  What are the symbols, like Private, PFD, Corporal, or 1stLt, 2ndLt, Capt?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**

enum Enlisted
{
    PVT, PV2, PFC, SPC, CPL, SGT
}


2.  Using the Ranks enum, assign a rank to yourself or a friend.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**

    Enlisted Kenneth = Enlisted.SGT;

3.  Determine the numeric index of particular ranks, using the Ranks enum?
 
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  The code - Console.WriteLine((int) Kenneth); returns the integer value of 6.

4.  How do you select the type of an enum?
  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  enum Enlisted : short {PVT, …, SGT}

5.  Are structs stored on the stack or on the heap?  What about enums?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  Structs and enums are both value types that are stored on the stack.

6.  Declare a struct named DOD with four branches.

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**

struct DOD
{
private string army , navy, airforce, coastguard;
}

7.  Why can’t you create a default constructor for a struct?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  You can’t delete your own default constructor for a structure because the compiler will always generate one for you.

8.  What is CIL?  What does the CLR do to the CIL?

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**  CIL stands for Common Intermediate Language (CIL).  The CIL is the compiler that converts the C# code into a set of instructions which are stored in an assembly.  The CLR converts the CIL instructions into real machine instructions that the processor on your computer can understand and execute.










