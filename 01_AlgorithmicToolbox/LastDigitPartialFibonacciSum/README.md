### Problem Introduction

Now, we would like to find the last digit of a partial sum of Fibonacci numbers: *𝐹<sub>𝑚</sub>* + *𝐹<sub>𝑚+1</sub>* + · · · + *𝐹<sub>𝑛</sub>*

### Problem Description

**Task.** Given two non-negative integers *𝑚* and *𝑛*, where *𝑚* ≤ *𝑛*, find the last digit of the sum *𝐹<sub>𝑚</sub>* + *𝐹<sub>𝑚+1</sub>* +
· · · + *𝐹<sub>𝑛</sub>*

**Input Format.** The input consists of two non-negative integers *𝑚* and *𝑛* separated by a space.

**Constraints.** 0 ≤ *𝑚* ≤ *𝑛* ≤ 10<sup>18</sup>

**Output Format.** Output the last digit of *𝐹<sub>𝑚</sub>* + *𝐹<sub>𝑚+1</sub>* + · · · + *𝐹<sub>𝑛</sub>*

**Time Limits.** 

 language | C | C++ | Java | Python | C# | Haskell | JavaScript | Ruby | Scala 
| ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ |
 time (sec) | 1 | 1 | 1.5 | 5 | 1.5 | 2 | 5 | 5 | 3 

**Memory Limit.** 512MB.

**Sample 1**

Input
----|
3 7

Output
-----|
1

Explanation:
*𝐹<sub>3</sub>* + *𝐹<sub>4</sub>* + *𝐹<sub>5</sub>* + *𝐹<sub>6</sub>* + *𝐹<sub>7</sub>* = 2 + 3 + 5 + 8 + 13 = 31

**Sample 2**

Input
----|
10 10

Output
------|
5

Explanation: *𝐹<sub>10</sub>* = 55

**Sample 3**

Input
-----|
10 200

Output
-----|
2

Explanation: *𝐹<sub>10</sub>* + *𝐹<sub>11</sub>* + · · · + *𝐹<sub>200</sub>* = 734 544 867 157 818 093 234 908 902 110 449 296 423 262
