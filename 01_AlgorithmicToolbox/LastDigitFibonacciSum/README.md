### Problem Introduction

The goal in this problem is to find the last digit of a sum of the first *𝑛* Fibonacci numbers.


### Problem Description

**Task.** Given an integer *𝑛*, find the last digit of the sum *𝐹<sub>0</subsub>* + *𝐹<sub>1</subsub>* + · · · + *𝐹<sub>n</subsub>*.

**Input Format.** The input consists of a single integer *𝑛*.

**Constraints.** 0 ≤ *𝑛* ≤ 10<sup>18</sup>

**Output Format.** Output the last digit of *𝐹<sub>0</subsub>* + *𝐹<sub>1</subsub>* + · · · + *𝐹<sub>n</subsub>*.

**Time Limits.** 

 language | C | C++ | Java | Python | C# | Haskell | JavaScript | Ruby | Scala 
| ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ |
 time (sec) | 1 | 1 | 1.5 | 5 | 1.5 | 2 | 5 | 5 | 3 

**Memory Limit.** 512MB.

**Sample 1**

Input
----|
3

Output
-----|
4

Explanation:
*𝐹<sub>0</subsub>* + *𝐹<sub>1</subsub>* + *𝐹<sub>2</subsub>* + *𝐹<sub>3</subsub>* = 0 + 1 + 1 + 2 = 4

**Sample 2**

Input
----|
100

Output
-----|
5

Explanation:
The sum is equal to 927 372 692 193 078 999 175, the last digit is 5

**Sample 3**

Input
----|
99999999999999999

Output
-----|
0

Explanation:
The number is too big to fit on this page, but the last digit is 0
