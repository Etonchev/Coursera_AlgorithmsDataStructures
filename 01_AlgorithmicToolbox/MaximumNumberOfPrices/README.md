### Problem Introduction

You are organizing a funny competition for children. As a prize fund you have *𝑛*
candies. You would like to use these candies for top *𝑘* places in a competition
with a natural restriction that a higher place gets a larger number of candies.
To make as many children happy as possible, you are going to find the largest
value of *𝑘* for which it is possible.

### Problem Description

**Task.** The goal of this problem is to represent a given positive integer *𝑛* as a sum of as many pairwise
distinct positive integers as possible. That is, to find the maximum *𝑘* such that *𝑛* can be written as
*𝑎<sub>1</sub>* + *𝑎<sub>2</sub>* + · · · + *𝑎<sub>𝑘</sub>* where *𝑎<sub>1</sub>*, . . . , *𝑎<sub>𝑘</sub>* are positive integers and *𝑎<sub>𝑖</sub>* &nbsp; ̸= *𝑎<sub>𝑗</sub>* for all 1 ≤ *𝑖* < *𝑗* ≤ *𝑘*.

**Input Format.** The input consists of a single integer *𝑛*.
Constraints. 1 ≤ *𝑛* ≤ 10<sup>9</sup>

**Output Format.** In the first line, output the maximum number *𝑘* such that *𝑛* can be represented as a sum
of *𝑘* pairwise distinct positive integers. In the second line, output *𝑘* pairwise distinct positive integers
that sum up to *𝑛* (if there are many such representations, output any of them).

**Time Limits.** 

| language | C | C++ | Java | Python | C# | Haskell | JavaScript | Ruby | Scala |
| ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ |
| time (sec) | 1 | 1 | 1.5 | 5 | 1.5 | 2 | 5 | 5 | 3 |

**Memory Limit.** 512MB.

**Sample 1**

|Input|
|-----|
|6|

|Output|
|------|
|3|
|1 2 3|


**Sample 2**

|Input|
|-----|
|8|

|Output|
|------|
|3|
|1 2 5|


**Sample 3**

|Input|
|-----|
|2|

|Output|
|------|
|1|
|2|