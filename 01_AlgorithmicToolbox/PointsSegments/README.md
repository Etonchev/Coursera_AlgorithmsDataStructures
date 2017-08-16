### Problem Introduction

You are organizing an online lottery. To participate, a person bets on a single
integer. You then draw several ranges of consecutive integers at random.
A participant’s payoff then is proportional to the number of ranges that
contain the participant’s number minus the number of ranges that does not
contain it. You need an efficient algorithm for computing the payoffs for all
participants. A naive way to do this is to simply scan, for all participants, the
list of all ranges. However, you lottery is very popular: you have thousands
of participants and thousands of ranges. For this reason, you cannot afford
a slow naive algorithm.

### Problem Description

**Task.** You are given a set of points on a line and a set of segments on a line. The goal is to compute, for
each point, the number of segments that contain this point.

**Input Format.** The first line contains two non-negative integers *𝑠* and *𝑝* defining the number of segments
and the number of points on a line, respectively. The next *𝑠* lines contain two integers *𝑎<sub>𝑖</sub>*, *𝑏<sub>𝑖</sub>* defining
the *𝑖*-th segment [*𝑎<sub>𝑖</sub>*, *𝑏<sub>𝑖</sub>*]. The next line contains *𝑝* integers defining points *𝑥<sub>1</sub>*, *𝑥<sub>2</sub>*, . . . , *𝑥<sub>𝑝</sub>*.

**Constraints.** 1 ≤ *𝑠*, *𝑝* ≤ 50000; −10<sup>8</sup> ≤ *𝑎<sub>𝑖</sub>* ≤ *𝑏<sub>𝑖</sub>* ≤ 10<sup>8</sup> for all 0 ≤ *𝑖* < *𝑠*; −10<sup>8</sup> ≤ *𝑥<sub>𝑗</sub>* ≤ 10<sup>8</sup> for all 0 ≤ *𝑗* < *𝑝*.

**Output Format.** Output 𝑝 non-negative integers *𝑘<sub>0</sub>*, *𝑘<sub>1</sub>*, . . . , *𝑘<sub>𝑝−1</sub>* where *𝑘<sub>𝑖</sub>* is the number of segments which
contain *𝑥<sub>𝑖</sub>*. More formally, *𝑘<sub>𝑖</sub>* = |{*𝑗* : *𝑎<sub>𝑗</sub>* ≤ *𝑥<sub>𝑖</sub>* ≤ *𝑏<sub>𝑗</sub>*}|

**Time Limits.** 

| language | C | C++ | Java | Python | C# | Haskell | JavaScript | Ruby | Scala |
| ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ |
| time (sec) | 3 | 3 | 4.5 | 15 | 4.5 | 6 | 15 | 15 | 9 |

**Memory Limit.** 512MB.

**Sample 1**

|Input|
|-----|
|2 3|
|0 5|
|7 10|
|1 6 11|

|Output|
|------|
|1 0 0|

Explanation:
Here, we have two segments and three points. The first point lies only in the first segment while the
remaining two points are outside of all the given segments

**Sample 2**

|Input|
|-----|
|1 3|
|-10 10|
|-100 100 0|

|Output|
|------|
|0 0 1|

**Sample 3**

|Input|
|-----|
|3 2|
|0 5|
|-3 2|
|7 10|
|1 6|

|Output|
|------|
|2 0|

**Sample 4**

|Input|
|-----|
|2 1|
|5 5|
|5 5|
|5|

|Output|
|------|
|2|

**Sample 5**

|Input|
|-----|
|1 3|
|0 10|
|5 5 5|

|Output|
|------|
|1 1 1 |