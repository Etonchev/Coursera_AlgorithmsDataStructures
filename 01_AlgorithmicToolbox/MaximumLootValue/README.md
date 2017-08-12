### Problem Introduction

A thief finds much more loot than his bag can fit. Help him to find the most valuable combination
of items assuming that any fraction of a loot item can be put into his bag.

### Problem Description
Task. The goal of this code problem is to implement an algorithm for the fractional knapsack problem.

**Input Format.** The first line of the input contains the number *𝑛* of items and the capacity *𝑊* of a knapsack.
The next *𝑛* lines define the values and weights of the items. The *𝑖*-th line contains integers *𝑣<sub>𝑖</sub>* and *𝑤<sub>𝑖</sub>*—the
value and the weight of *𝑖*-th item, respectively.

**Constraints.** 1 ≤ *𝑛* ≤ 10<sup>3</sup>, 0 ≤ *𝑊* ≤ 2 · 10<sup>6</sup>; 0 ≤ *𝑣<sub>𝑖</sub>* ≤ 2 · 10<sup>6</sup>, 0 < *𝑤<sub>𝑖</sub>* ≤ 2 · 10<sup>6</sup> for all 1 ≤ *𝑖* ≤ *𝑛*. All the
numbers are integers.

**Output Format.** Output the maximal value of fractions of items that fit into the knapsack. The absolute
value of the difference between the answer of your program and the optimal value should be at most
10<sup>−3</sup>
. To ensure this, output your answer with at least four digits after the decimal point (otherwise
your answer, while being computed correctly, can turn out to be wrong because of rounding issues).

**Time Limits.** 

| language | C | C++ | Java | Python | C# | Haskell | JavaScript | Ruby | Scala |
| ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ |
| time (sec) | 1 | 1 | 1.5 | 5 | 1.5 | 2 | 5 | 5 | 3 |

**Memory Limit.** 512MB.

**Sample 1**

|Input|
|-----|
|3 50|
|60 20|
|100 50|
|120 30|

|Output|
|------|
|180.0000|

Explanation: To achieve the value 180, we take the first item and the third item into the bag.

**Sample 2**

|Input|
|-----|
|1 10|
|500 30|

|Output|
|------|
|166.6667|

Explanation: Here, we just take one third of the only available item.
