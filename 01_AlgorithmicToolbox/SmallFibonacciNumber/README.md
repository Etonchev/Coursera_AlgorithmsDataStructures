### Problem Introduction 

Recall the definition of Fibonacci sequence: *𝐹<sub>0</sub> = 0, 𝐹<sub>1</sub> = 1*, and 
*𝐹<sub>𝑖</sub> = 𝐹<sub>𝑖−1</sub> + 𝐹<sub>𝑖−2</sub> for 𝑖 ≥ 2*. Your goal in this problem is to implement an 
efficient algorithm for computing Fibonacci numbers. The starter files for this problem contain an implementation of 
the following naive recursive algorithm for computing Fibonacci numbers in C++, Java, and Python3:

    Fibonacci(𝑛): 
    if 𝑛 ≤ 1: 
      return 𝑛 
    return Fibonacci(𝑛 − 1) + Fibonacci(𝑛 − 2)

Try compiling and running a starter solution on your machine. You will see that computing, say, *𝐹<sub>40</sub>* already takes 
noticeable time.
Another way to appreciate the dramatic difference between an exponential time algorithm and a polynomial time algorithm is to 
use the following visualization by David Galles: http://www.cs.usfca.edu/~galles/visualization/DPFib.html. 
Try computing *𝐹<sub>20</sub>* by a recursive algorithm by entering “20” and pressing the “Fibonacci Recursive” button. 
You will see an endless number of recursive calls. Now, press “Skip Forward” to stop the current algorithm and call the 
iterative algorithm by pressing “Fibonacci Table”. This will compute *𝐹<sub>20</sub>* very quickly. 
(Note that the visualization uses a slightly different definition of Fibonacci numbers: *𝐹<sub>0</sub> = 1* instead of *𝐹<sub>0</sub> = 0*. 
This of course has almost no influence on the running time.) 

### Problem Description 

**Task.** Given an integer *𝑛*, find the *𝑛*th Fibonacci number 𝐹<sub>𝑛</sub>.

**Input Format.** The input consists of a single integer 𝑛. 

**Constraints.** 0 ≤ *𝑛* ≤ 45. 

**Output Format.** Output *𝐹<sub>𝑛</sub>*. 

**Time Limits.** 

 language | C | C++ | Java | Python | C# | Haskell | JavaScript | Ruby | Scala 
| ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ |
 time (sec) | 1 | 1 | 1.5 | 5 | 1.5 | 2 | 5 | 5 | 3 

**Memory Limit.** 512MB. 

**Sample 1**

Input: 3 

Output: 2 

Explanation: *𝐹<sub>3</sub>* = 2

**Sample 2** 

Input: 10 

Output: 55 

Explanation: *𝐹<sub>10</sub>* = 55
