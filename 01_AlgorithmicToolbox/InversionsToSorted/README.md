### Problem Introduction

An inversion of a sequence *𝑎<sub>0</sub>*, *𝑎<sub>1</sub>*, . . . , *𝑎<sub>𝑛−1</sub>* is a pair of indices 0 ≤ *𝑖* < *𝑗* < *𝑛* such
that *𝑎<sub>𝑖* > *𝑎<sub>𝑗* . The number of inversions of a sequence in some sense measures how
close the sequence is to being sorted. For example, a sorted (in non-descending
order) sequence contains no inversions at all, while in a sequence sorted in descending
order any two elements constitute an inversion (for a total of *𝑛*(*𝑛* − 1)/2 inversions).

### Problem Description

**Task.** The goal in this problem is to count the number of inversions of a given sequence.
Input Format. The first line contains an integer *𝑛*, the next one contains a sequence of integers
*𝑎<sub>0</sub>*, *𝑎<sub>1</sub>*, . . . , *𝑎<sub>𝑛−1</sub>*.

**Constraints.** 1 ≤ *𝑛* ≤ 10<sup>5</sup>, 1 ≤ *𝑎<sub>𝑖</sub>* ≤ 10<sup>9</sup> for all 0 ≤ *𝑖* < *𝑛*.

**Output Format.** Output the number of inversions in the sequence.**Time Limits.** 

|language | C | C++ | Java | Python | C# | Haskell | JavaScript | Ruby | Scala |
| ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ |
|time (sec) | 3 | 3 | 4.5 | 15 | 4.5 | 6 | 15 | 15 | 9 |

**Memory Limit.** 512MB.

**Sample 1**

|Input|
|-----|
|5|
|2 3 9 2 9|

|Output|
|------|
|2|

Explanation: The two inversions here are (1, 3) (*𝑎<sub>1</sub>* = 3 > 2 = *𝑎<sub>3</sub>*) and (2, 3) (*𝑎<sub>2</sub>* = 9 > 2 = *𝑎<sub>3</sub>*)**Sample 2**|Input||-----||6||9 8 7 3 2 1||Output||------||15|