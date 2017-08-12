### Problem Introduction

In this problem, you will design and implement an elementary greedy algorithm
used by cashiers all over the world millions of times per day.

### Problem Description

**Task.** The goal in this problem is to fnd the minimum number of coins needed to change the input value
(an integer) into coins with denominations 1, 5, and 10.

**Input Format.** The input consists of a single integer *m*.

**Constraints.** 1 ≤ *m* ≤ 10<sup>3</sup>.

**Output Format.** Output the minimum number of coins with denominations 1, 5, 10 that changes *m*.

**Time Limits.** 

 language | C | C++ | Java | Python | C# | Haskell | JavaScript | Ruby | Scala 
| ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ |
 time (sec) | 1 | 1 | 1.5 | 5 | 1.5 | 2 | 5 | 5 | 3 

**Memory Limit.** 512MB.


**Sample 1**

Input
----|
2

Output
-----|
2

Explanation: 2 = 1 + 1

**Sample 2**

Input
----|
28

Output
-----|
6

Explanation: 28 = 10 + 10 + 5 + 1 + 1 + 1
