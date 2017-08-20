### Problem Introduction

This problem is about implementing an algorithm for the knapsack without repetitions problem.

### Problem Description

**Task.** In this problem, you are given a set of bars of gold and your goal is to take as much gold as possible
into your bag. There is just one copy of each bar and for each bar you can either take it or not (hence
you cannot take a fraction of a bar).

**Input Format.** The first line of the input contains the capacity W of a knapsack and the number *n* of bars
of gold. The next line contains n integers *w<sub>0</sub>*, *w<sub>1</sub>*, . . . , *w<sub>n−1</sub>* defining the weights of the bars of gold.

**Constraints.** 1 ≤ *W* ≤ 10<sup>4</sup>; 1 ≤ *n* ≤ 300; 0 ≤ *w<sub>0</sub>*, . . . , *w<sub>n−1</sub>* ≤ 10<sup>5</sup>

**Output Format.** Output the maximum weight of gold that fits into a knapsack of capacity W.**Time Limits.** 

| language | C | C++ | Java | Python | C# | Haskell | JavaScript | Ruby | Scala |
| ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ |
| time (sec) | 2 | 2 | 3 | 10| 3 | 4 | 10 | 10 | 6 |

**Memory Limit.** 512MB.

**Sample 1**

|Input|
|-----|
|10 3|
|1 4 8|

|Output|
|------|
|9|

Explanation: Here, the sum of the weights of the first and the last bar is equal to 9.**Sample 2**

|Input|
|-----|
|20 4|
|5 7 12 18|

|Output|
|------|
|19|