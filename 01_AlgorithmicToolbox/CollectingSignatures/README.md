### Problem Introduction

You are responsible for collecting signatures from all tenants of a certain building.
For each tenant, you know a period of time when he or she is at home.
You would like to collect all signatures by visiting the building as few times as
possible.
The mathematical model for this problem is the following. You are given a set
of segments on a line and your goal is to mark as few points on a line as possible
so that each segment contains at least one marked point.

### Problem Description

**Task.** Given a set of *𝑛* segments {[*𝑎<sub>0</sub>*, *𝑏<sub>0</sub>*], [*𝑎<sub>1</sub>*, *𝑏<sub>1</sub>*], . . . , [*𝑎<sub>𝑛−1</sub>*, *𝑏<sub>𝑛−1</sub>*]} with integer coordinates on a line, find
the minimum number *𝑚* of points such that each segment contains at least one point. That is, find a
set of integers *𝑋* of the minimum size such that for any segment [*𝑎<sub>𝑖</sub>*, *𝑏<sub>𝑖</sub>*] there is a point *𝑥* ∈ *𝑋* such
that *𝑎<sub>𝑖</sub>* ≤ *𝑥* ≤ *𝑏<sub>𝑖</sub>*

**Input Format.** The first line of the input contains the number 𝑛 of segments. Each of the following *𝑛* lines
contains two integers *𝑎<sub>𝑖</sub>* and *𝑏<sub>𝑖</sub>* (separated by a space) defining the coordinates of endpoints of the *𝑖*-th
segment.

**Constraints.** 1 ≤ *𝑛* ≤ 100; 0 ≤ *𝑎<sub>𝑖</sub>* ≤ *𝑏<sub>𝑖</sub>* ≤ 10<sup>9</sup> for all 0 ≤ *𝑖* < *𝑛*.

**Output Format.** Output the minimum number *𝑚* of points on the first line and the integer coordinates
of *𝑚* points (separated by spaces) on the second line. You can output the points in any order. If there
are many such sets of points, you can output any set. (It is not difficult to see that there always exist
a set of points of the minimum size such that all the coordinates of the points are integers.)

**Time Limits.** 

| language | C | C++ | Java | Python | C# | Haskell | JavaScript | Ruby | Scala |
| ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ |
| time (sec) | 1 | 1 | 1.5 | 5 | 1.5 | 2 | 5 | 5 | 3 |

**Memory Limit.** 512MB.

**Sample 1**

|Input|
|-----|
|3|
|1 3|
|2 5|
|3 6|

|Output|
|------|
|1|
|3|

Explanation: In this sample, we have three segments: [1, 3], [2, 5], [3, 6] (of length 2, 3, 3 respectively).
All of them contain the point with coordinate 3: 1 ≤ 3 ≤ 3, 2 ≤ 3 ≤ 5, 3 ≤ 3 ≤ 6.

**Sample 2**

|Input|
|-----|
|4|
|4 7|
|1 3|
|2 5|
|5 6|

|Output|
|------|
|2|
|3 6|

Explanation:
The second and the third segments contain the point with coordinate 3 while the first and the fourth
segments contain the point with coordinate 6. All the four segments cannot be covered by a single
point, since the segments [1, 3] and [5, 6] are disjoint.