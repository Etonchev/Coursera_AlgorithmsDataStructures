### Problem Introduction

Your goal in this problem is to find the last digit of *𝑛*-th Fibonacci number. Recall that Fibonacci numbers
grow exponentially fast. For example,

<p align="center">𝐹<sub>200</sub> = 280 571 172 992 510 140 037 611 932 413 038 677 189 525</p>

Therefore, a solution like

    𝐹[0] ← 0
    𝐹[1] ← 1
    for 𝑖 from 2 to 𝑛:
    	𝐹[𝑖] ← 𝐹[𝑖 − 1] + 𝐹[𝑖 − 2]
    print(𝐹[𝑛] mod 10)

will turn out to be too slow, because as *𝑖* grows the *𝑖*-th iteration of the loop computes the sum of longer
and longer numbers. Also, for example, *𝐹<sub>1000</sub>* does not fit into the standard C++ int type. To overcome
this difficulty, you may want to store in 𝐹[𝑖] not the *𝑖*-th Fibonacci number itself, but just its last digit (that
is, *𝐹<sub>𝑖</sub>* mod 10). Computing the last digit of *𝐹<sub>𝑖</sub>*
is easy: it is just the last digit of the sum of the last digits of
*𝐹<sub>𝑖−1</sub>* and *𝐹<sub>𝑖−2</sub>*:

    𝐹[𝑖] ← (𝐹[𝑖 − 1] + 𝐹[𝑖 − 2]) mod 10
	
This way, all 𝐹[𝑖]’s are just digits, so they fit perfectly into any standard integer type, and computing a sum
of 𝐹[𝑖 − 1] and 𝐹[𝑖 − 2] is performed very quickly.

### Problem Description

**Task.** Given an integer 𝑛, find the last digit of the *𝑛*-th Fibonacci number *𝐹<sub>n</sub>* (that is, *𝐹<sub>n</sub>* mod 10).

**Input Format.** The input consists of a single integer *𝑛*.

**Constraints.** 0 ≤ *𝑛* ≤ 107

**Output Format.** Output the last digit of 𝐹𝑛.

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

Input: 331

Output: 9

Explanation: *𝐹<sub>331</sub>* = 668 996 615 388 005 031 531 000 081 241 745 415 306 766 517 246 774 551 964 595 292 186 469


**Sample 3**

Input: 327305

Output: 5

Explanation: *𝐹<sub>327305</sub>* does not fit into one line, but its last digit is equal to 5

