### Problem

Given a sequence of non-negative integers *a<sub>0</sub>,…,a<sub>n−1</sub>*, find the maximum pairwise product, that is, the largest integer that can be obtained by multiplying two different elements from the sequence (or, more formally, *max<sub>0≤i≠j≤n−1</sub> a<sub>i</sub>a<sub>j</sub>*). Different elements here mean *a<sub>i</sub>* and *a<sub>j</sub>* with *i ≠ j* (it can be the case that *a<sub>i</sub>=a<sub>j</sub>*).

### Input format

The first line of the input contains an integer *n*. The next line contains *n* non-negative integers *a<sub>0</sub>,…,a<sub>n−1</sub>* (separated by spaces).

### Constraints

*2≤n≤2⋅10<sup>5</sup>; 0≤a<sub>0</sub>,…,a<sub>n−1</sub>≤10<sup>5</sup>*

### Output format

Output a single number — the maximum pairwise product.

**Sample 1**

Input
------|
3
1 2 3


Output
------|
6

Explanation
6= 2 × 3


**Sample 2**

Input
------|
10
7 5 14 2 8 8 10 1 2 3

Output
------|
140

Explanation
140 = 14 × 10


**Sample 3**

Input
------|
5
4 6 2 6 1

Output
------|
36

Explanation
36 = 6 x 6
