**Problem Introduction**

In this problem, your goal is to compute *𝐹<sub>𝑛</sub>* modulo *𝑚*, where *𝑛* may be really huge: up to 1018. For such
values of *𝑛*, an algorithm looping for 𝑛 iterations will not fit into one second for sure. Therefore we need to
avoid such a loop.
To get an idea how to solve this problem without going through all *𝐹<sub>i</sub>* for *𝑖* from 0 to *𝑛*, let’s see what
happens when *𝑚* is small — say, *𝑚* = 2 or *𝑚* = 3.


|  *i* | 0  | 1  | 2  | 3  | 4  | 5  | 6  | 7  | 8  | 9  | 10  | 11  | 12  | 13  | 14  | 15  |
| ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ |
| *F<sub>i</sub>*  | 0  | 1  | 1  | 2  | 3  | 5  | 8  | 13  | 21  | 34  | 55  | 89  | 144  | 233  | 377  | 610  |
| *F<sub>i</sub>* mod 2  | 0  | 1  | 1  | 0  | 1  | 1  | 0  | 1  | 1  | 0  | 1  | 1  | 0  | 1  | 1  | 0  |
| *F<sub>i</sub>* mod 3  | 0  | 1  | 1  | 2  | 0  | 2  | 2  | 1  | 0  | 1  | 1  | 2  | 0  | 2  | 2  | 1  |

Take a detailed look at this table. Do you see? Both these sequences are periodic! For *𝑚* = 2, the period
is 011 and has length 3, while for *𝑚* = 3 the period is 01120221 and has length 8. Therefore, to compute,
say, *𝐹<sub>2015</sub>* mod 3 we just need to find the remainder of 2015 when divided by 8. Since 2015 = 251 · 8 + 7, we
conclude that *𝐹<sub>2015</sub>* mod 3 = *𝐹<sub>7</sub>* mod 3 = 1.
This is true in general: for any integer *𝑚* ≥ 2, the sequence *𝐹<sub>𝑛</sub>* mod *𝑚* is periodic. The period always
starts with 01 and is known as Pisano period.
</br>Handy list with pisano period lengths: http://webspace.ship.edu/msrenault/fibonacci/fiblist.htm

### Problem Description

**Task.** Given two integers *𝑛* and *𝑚*, output *𝐹<sub>𝑛</sub>* mod *𝑚* (that is, the remainder of *𝐹<sub>𝑛</sub>* when divided by *𝑚*).

**Input Format.** The input consists of two integers *𝑛* and *𝑚* given on the same line (separated by a space).

**Constraints.** 1 ≤ *𝑛* ≤ 10<sup>18</sup>, 2 ≤ 𝑚 ≤ 10<sup>5</sup>

**Output Format.** Output *𝐹<sub>𝑛</sub>* mod *𝑚* .


**Time Limits.** 

 language | C | C++ | Java | Python | C# | Haskell | JavaScript | Ruby | Scala 
| ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ |
 time (sec) | 1 | 1 | 1.5 | 5 | 1.5 | 2 | 5 | 5 | 3 

**Memory Limit.** 512MB.

**Sample 1**

Input
-----|
1 239

Output
-----|
1

Explanation:
*𝐹<sub>1</sub>* mod 239 = 1 mod 239 = 1

**Sample 2**

Input
-----|
239 1000

Output
-----|
161

Explanation:
*𝐹<sub>239</sub>* mod 1 000 = 39 679 027 332 006 820 581 608 740 953 902 289 877 834 488 152 161 (mod 1 000) = 161

**Sample 3**

Input
-----|
2816213588 30524

Output
-----|
10249

Explanation:
*𝐹<sub>2 816 213 588</sub>* does not fit into one page, but *𝐹<sub>2 816 213 588</sub>* mod 30 524 = 10 249
