# C# DivideByZeroException Bug

This repository demonstrates a common error in C#: the `DivideByZeroException`. The `bug.cs` file contains code that can throw this exception if a variable used as a divisor is zero.  The solution is shown in `bugSolution.cs`.

## Bug Description
The `MyMethod` function in `bug.cs` divides 10 by `MyProperty`. If `MyProperty` is 0, a `DivideByZeroException` will be thrown. This is a runtime exception and, if not handled, will crash the application.

## Solution
The `bugSolution.cs` file shows how to mitigate this issue by checking if `MyProperty` is zero before performing the division. This prevents the exception from occurring.