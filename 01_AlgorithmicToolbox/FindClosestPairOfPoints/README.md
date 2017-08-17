### Problem Introduction

In this problem, your goal is to find the closest pair of points among the given *𝑛*
points. This is a basic primitive in computational geometry having applications in,
for example, graphics, computer vision, traffic-control systems.

### Problem Description

**Task.** Given *𝑛* points on a plane, find the smallest distance between a pair of two (different) points. Recall
that the distance between points (*𝑥<sub>1</sub>*, *𝑦<sub>1</sub>*) and (*𝑥<sub>2</sub>*, *𝑦<sub>2</sub>*) is equal to sqrt((*𝑥<sub>1</sub>* − *𝑥<sub>2</sub>*)<sup>2</sup> + (*𝑦<sub>1</sub>* − *𝑦<sub>2</sub>*)<sup>2</sup>)

**Input Format.** The first line contains the number *𝑛* of points. Each of the following *𝑛* lines defines a point (*𝑥<sub>𝑖</sub>*, *𝑦<sub>𝑖</sub>*).

**Constraints.** 1 ≤ *𝑛* ≤ 10<sup>5</sup>; −10<sup>9</sup> ≤ *𝑥<sub>𝑖</sub>*, *𝑦<sub>𝑖</sub>* ≤ 10<sup>9</sup> are integers.

**Output Format.** Output the minimum distance. The absolute value of the difference between the answer
of your program and the optimal value should be at most 10<sup>−3</sup>. To ensure this, output your answer
with at least four digits after the decimal point (otherwise your answer, while being computed correctly,
can turn out to be wrong because of rounding issues).

**Time Limits.** 

| language | C | C++ | Java | Python | C# | Haskell | JavaScript | Ruby | Scala |
| ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ |
| time (sec) | 2 | 2 | 3 | 10 | 3 | 4 | 10 | 10 | 6 |

**Memory Limit.** 512MB.

**Sample 1**

|Input|
|-----|
|2|
|0 0|
|3 4|

|Output|
|------|
|5.0|

Explanation: There are only two points here. The distance between them is 5

**Sample 2**

|Input|
|-----|
|4|
|7 7|
|1 100|
|4 8|
|7 7|

|Output|
|------|
|0.0|

Explanation: There are two coinciding points among the four given points. Thus, the minimum distance is zero

**Sample 3**

|Input|
|-----|
|11|
|4 4|
|-2 -2|
|-3 -4|
|-1 3|
|2 3|
|-4 0|
|1 1|
|-1 -1|
|3 -1|
|-4 2|
|-2 4|

|Output|
|------|
|1.414213|

Explanation: The smallest distance is sqrt(2). There are two pairs of points at this distance: (−1, −1) and (−2, −2); (−2, 4) and (−1, 3)