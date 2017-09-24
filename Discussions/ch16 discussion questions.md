# Chapter 16. Discussion Questions
## Kenneth Clark
### September 24, 2017  

1.  Give five examples (using valid C# code) of the five bitwise operators listed in the text.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** The NOT (~) operator;  11001100 (204 decimal), after applying the ~ operator the result is 00110011 (51 decimal).  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ex:  var temp = ~5;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; The left-shift (<<) operator;  204 << 2.  In binary, 204 decimal is 11001100.  After shifting left two places yields the result 00110000, which is 48.  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ex:  var temp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;        temp = 14 << 2;

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; The OR (|) operator;  204 | 24 returns the value 220 (204 is 11001100, 24 is 00011000, and 220 is 11011100).  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ex:  x | y;

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; The AND (&) operator;  204 & 24 returns the value 8.  (204 is 11001100, 24 is 00011000, and 8 is 00001000).
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ex:  int i = 0;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;         if (false & ++ I == 1) 


&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; The XOR(^) operator;  204 ^ 24 is 212 (11001100 ^ 00011000 is 11010100)

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ex:  0101 ^ 1100 = 1001


2.  Does C# implement the right-shift (>>) operator?  If so, give an example of its operation using valid C# code.
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** Yes, C# does implement the right-shift (>>) operator.  
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Ex:  var temp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;        temp = -14 >> 2;

3.  Explain in detail this code: bits & (1 << index);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** Left shift from 1 (in parenthesis) to whatever number ‘index’ represents and compares if the value in parenthesis is the same (‘&’ operator) to the value of ‘bits’

4.  Explain in detail this code:  bits |= (1 << index);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** Turn the bit on if the value is true, otherwise, turn it off

5.  Explain in detail this code:  bits &= (1<<index);
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** Turn the bit on.

6.  How does C# interpret this?  bool peek = bits[n];
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** It assigns the value of ‘bits[n]’ (either true or false) to the varable ‘peek’

7.  How does C# interpret this?  bits[n] = true;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** Assigns the value of ‘bits[n]’ to true.

8.  How does C# interpret this?  bits[n] ^= true;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:** Assigns the value of ‘bits[n]’ to false

9.  Assume that users were assigned read, write, and execute permissions according to this scheme: read = 1, write = 2, execute = 4.  How would you interpret the following user permissions:
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (a) permission = 0  = no permission
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (b) permission = 1 = read
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (c) permission = 2 = write
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (d) permission = 3 = read and write
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (e) permission = 4 = execute
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (f) permission = 5 = read and execute
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (g) permission = 6 = write and execute
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (h) permission = 7 = read, write and execute

10.  Answer the previous question by converting the decimal permission into binary permissions.  What does this tell you about using this scheme of permissions?
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;**Answer:**
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (a) 000
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (b) 001
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (c) 010
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (d) 011
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (e) 100
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (f) 101
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (g) 110
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; (h) 111





















