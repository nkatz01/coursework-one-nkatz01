# Coursework One — Rational Numbers

## Aims

+ To give you practice with creating classes.
+ To give you practice using immutable data types.
+ To give you practice working with an existing code base.
+ To give you practice using a revision control system (`git`).
+ To give you practice reading APIs.
+ To give you more practice with string manipulation.
+ To give you further practice with TDD and unit testing.

## Preamble

A *rational number* is defined as the quotient of two integers `a` and `b`, called the *numerator* and *denominator*, respectively, where `b != 0`.

+ The absolute value `|r|` of the rational number `r = a/b` is equal to `|a|/|b|`.
+ The sum of two rational numbers `r1 = a1/b1` and `r2 = a2/b2` is `r1 + r2 = a1/b1 + a2/b2 = (a1 * b2 + a2 * b1) / (b1 * b2)`.
+ The difference of two rational numbers `r1 = a1/b1` and `r2 = a2/b2` is `r1 - r2 = a1/b1 - a2/b2 = (a1 * b2 - a2 * b1) / (b1 * b2)`.
+ The product (multiplication) of two rational numbers `r1 = a1/b1` and `r2 = a2/b2` is `r1 * r2 = (a1 * a2) / (b1 * b2)`.
+ Dividing a rational number `r1 = a1/b1` by another `r2 = a2/b2` is `r1 / r2 = (a1 * b2) / (a2 * b1)` if `a2 * b1` is not zero.
+ Exponentiation of a rational number `r = a/b` to a non-negative integer power `n` is `r^n = (a^n)/(b^n)`.
+ Exponentiation of a rational number `r = a/b` to a negative integer power `n` is `r^n = (b^m)/(a^m)`, where `m = |n|`.
+ Exponentiation of a rational number `r = a/b` to a real (floating-point) number `x` is the quotient `(a^x)/(b^x)`, which is a real number.
+ Exponentiation of a real number `x` to a rational number `r = a/b` is `x^(a/b) = root(x^a, b)`, where `root(p, q)` is the `q`th root of `p`.

## Requirements

Implement the following operations on Rational Numbers:
+
+ addition, subtraction, multiplication, and division of two rational numbers,
+ absolute value of a given rational number,
+ exponentiation of a given rational number to an integer power, 
+ exponentiation of a given rational number to a real (floating-point) power, 
+ exponentiation of a real number to a rational number, and
+ display as `n/d`, where `n` is the numerator and `d` is the denominator.

Your implementation should meet the following conditions:

+ All rational numbers should be *immutable*; that is, there should be no external mechanism to change the components of the number after it has been created; most of your methods will simply return a new rational number.
+ The denominator **may not** be zero.
+ The denominator should never be negative.  
	(You may provide a negative number for the denominator via the constructor when you create the rational, but a negative rational should be represented internally with a negative numerator and a positive denominator.)
+ Zero should be represented as `0/1`.
+ Always be reduced to *lowest terms*.  
For example, `4/4` should reduce to `1/1`, `30/60` should reduce to `1/2`, `12/8` should reduce to `3/2`, etc.  
To reduce a rational number `r = a/b`, divide `a` and `b` by the greatest common divisor (gcd) of `a` and `b`.  
For example, the `gcd(12, 8) = 4`, therefore `r = 12/8` can be reduced to `(12/4)/(8/4) = 3/2`.
+ Use (at least) one additional [extension method][extension].
+ Utilise [operator overloading methods][overload] for the `+`, `-`, `*`, and `/` operators.

Assume that the programming language you are using does not have an implementation of rational numbers.

## The code

+ You are provided with some skeletal code for both for the `Rational` entity and its tests.
+ You are required to complete the code.
+ You **should not** assume the provided code is correct — check it thoroughly.
+ In particular you should remember to add initial tests as the provided tests are "minimal".
+ Your goal in writing the tests for the `Rational` class is too test for every possible condition, including that the correct exceptions are thrown (where appropriate).

## Testing

Initially, only the first test will be enabled; this is to encourage you to solve the exercise one step at a time.
Once you get the first test to pass remove the `Skip` property from the next test, and continue to work on getting that test to pass (and the previous test(s)) - repeat until all the tests pass.

## Submission

Before submission, complete the `REVIEW.md` file, which should be at the top level of your repository, which contains the following:

```
Name: Your name should appear here

Your userid: e.g., myname01

Comments to the grader:

	Anything you want the grader to know; otherwise just remove this section.

Feedback to student

	Which will appear here including your grade.
```

Your repository will be automatically copied at the appropriate due date and time.


## Resources

+ [Rational Numbers](https://www.mathsisfun.com/rational-numbers.html)
+ [Wikipedia entry](https://en.wikipedia.org/wiki/Rational_number)

## Evaluation criteria

These general criteria may be varied on a per-coursework basis as "one size does not fit all".
The criteria are intentionally very broad as this gives us flexibility in the grading process.

+ Feedback is published back to your repository.
+ *Clean code* still comes first and this is echoed by the [KISS principle](https://en.wikipedia.org/wiki/KISS_principle) from the 1960's.  
+ *Premature Optimisation*, as described by one of the current programming *Gurus* — Martin Fowler (“[Yet Another Optimisation Article](http://martinfowler.com/ieeeSoftware/yetOptimization.pdf)”), is frowned upon.

The quality of your code, not just its correctness, will play a huge part in determining your grade. 
We will not hesitate to assign failure grades to working programs which are:
+ poorly structured, 
+ poorly commented, 
+ have poor identifier names and abbreviations, 
+ contain inappropriate hard-coded values, or 
+ are not easily maintainable.

| Percentage | Criteria |
|:---------:|-----------|
| 40% | For functionality, including testing, using the facilities of the language if possible, oh, and that your program works according to the specification! |
| 40% | For coding in the idiomatic style of the programming language (i.e., `C#`).
| 20% | For adequate comments, proper formatting, indentation, choosing proper names, following naming conventions, and for correct submission. |


## Credits

We have used this type of problem several times and its heritage has been lost in the mists of time!

[extension]: https://msdn.microsoft.com/en-us//library/bb383977.aspx
[overload]: https://docs.microsoft.com/en-gb/dotnet/csharp/language-reference/operators/operator-overloading


