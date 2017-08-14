### Problem Introduction

As the last question of a successful interview, your boss gives you a few pieces of paper
with numbers on it and asks you to compose a largest number from these numbers. The
resulting number is going to be your salary, so you are very much interested in maximizing
this number. How can you do this?
In the lectures, we considered the following algorithm for composing the largest number out of the given
single-digit numbers.

    LargestNumber(Digits):
    answer ← empty string
    while Digits is not empty:
        maxDigit ← −∞
        for digit in Digits:
            if digit ≥ maxDigit:
                maxDigit ← digit
        append maxDigit to answer
        remove maxDigit from Digits
    return answer

Unfortunately, this algorithm works only in case the input consists of single-digit numbers. For example, for
an input consisting of two integers 23 and 3 (23 is not a single-digit number!) it returns 233, while the largest
number is in fact 323. In other words, using the largest number from the input as the first number is not a
safe move.
Your goal in this problem is to tweak the above algorithm so that it works not only for single-digit
numbers, but for arbitrary positive integers.

### Problem Description

**Task.** Compose the largest number out of a set of integers.

**Input Format.** The first line of the input contains an integer *𝑛*. The second line contains integers
*𝑎<sub>1</sub>*, *𝑎<sub>2</sub>*, . . . , *𝑎<sub>𝑛</sub>*.

**Constraints.** 1 ≤ *𝑛* ≤ 100; 1 ≤ *𝑎<sub>𝑖</sub>* ≤ 10<sup>3</sup> for all 1 ≤ *𝑖* ≤ *𝑛*.

**Output Format.** Output the largest number that can be composed out of *𝑎<sub>1</sub>*, *𝑎<sub>2</sub>*, . . . , *𝑎<sub>𝑛</sub>*.

**Time Limits.** 

| language | C | C++ | Java | Python | C# | Haskell | JavaScript | Ruby | Scala |
| ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ | ------------ |
| time (sec) | 1 | 1 | 1.5 | 5 | 1.5 | 2 | 5 | 5 | 3 |

**Memory Limit.** 512MB.

**Sample 1**

|Input|
|-----|
|2|
|21 2|

|Output|
|------|
|221|

Explanation: Note that in this case the above algorithm also returns an incorrect answer 212.

**Sample 2**

|Input|
|-----|
|5|
|9 4 6 1 9|

|Output|
|------|
|99641|

Explanation: 
In this case, the input consists of single-digit numbers only, so the algorithm above computes the right
answer.

**Sample 3**

|Input|
|-----|
|3|
|23 39 92|

|Output|
|------|
|923923|

Explanation:
As a coincidence, for this input the above algorithm produces the right result, though the input does
not have any single-digit numbers.
