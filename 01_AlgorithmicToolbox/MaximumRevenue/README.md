### Problem Introduction

You have *𝑛* ads to place on a popular Internet page. For each ad, you know how
much is the advertiser willing to pay for one click on this ad. You have set up *𝑛*
slots on your page and estimated the expected number of clicks per day for each
slot. Now, your goal is to distribute the ads among the slots to maximize the
total revenue.

### Problem Description

**Task.** Given two sequences *𝑎<sub>1</sub>*, *𝑎<sub>2</sub>*, . . . , *𝑎<sub>n</sub>* (*𝑎<sub>i</sub>* is the profit per click of the *𝑖*-th ad) and *𝑏<sub>1</sub>*, 
*𝑏<sub>2</sub>*, . . . , *𝑏<sub>n</sub>* (*𝑏<sub>i</sub>* is
the average number of clicks per day of the *𝑖*-th slot), we need to partition them into *𝑛* pairs (*𝑎<sub>i</sub>*, *𝑏<sub>j</sub>* ) such that the sum of their 
products is maximized.

**Input Format.** The first line contains an integer *𝑛*, the second one contains a sequence of integers
*𝑎<sub>1</sub>*, *𝑎<sub>2</sub>*, . . . , *𝑎<sub>n</sub>*, the third one contains a sequence of integers *𝑏<sub>1</sub>*, *𝑏<sub>2</sub>*, . . . , *𝑏<sub>n</sub>*.

**Constraints.** 1 ≤ *𝑛* ≤ 10<sup>3</sup>; −10<sup>5</sup> ≤ *𝑎<sub>i</sub>*, *𝑏<sub>i</sub>* ≤ 10<sup>5</sup> for all 1 ≤ *𝑖* ≤ *𝑛*.

**Output Format.** Output the maximum value of ∑︀*𝑎<sub>i</sub>𝑐<sub>i</sub>*, where *𝑐<sub>1</sub>*, *𝑐<sub>2</sub>*, . . . , *𝑐<sub>n</sub>* is a permutation of *𝑏<sub>1</sub>*, *𝑏<sub>2</sub>*, . . . , *𝑏<sub>n</sub>*.

**Time Limits.** 

| language | C | C++ | Java | Python | C# | Haskell | JavaScript | Ruby | Scala |
| ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ |
| time (sec) | 1 | 1 | 1.5 | 5 | 1.5 | 2 | 5 | 5 | 3 |

**Memory Limit.** 512MB.

**Sample 1**

|Input|
|-----|
|1|
|23|
|39|

|Output|
|------|
|897|

Explanation: 897 = 23 · 39

**Sample 2**

|Input|
|-----|
|3|
|1 3 -5|
|-2 4 1|

|Output|
|------|
|23|

Explanation: 23 = 3 · 4 + 1 · 1 + (−5) · (−2)

**Sample 3**

|Input|
|-----|
|4|
|-4 10 12 20|
|-9 -3 -2 6|

|Output|
|------|
|102|

Explanation: 102 = 20 · 6 + 12 · (-2) + 10 · (-3) + (-4) · (-9)