# Java
> Create a function that takes two numbers as arguments (`num`, `length`) and returns an array of multiples of `num` until the array length reaches `length`.  
>   
> Examples  
> arrayOfMultiples(7, 5) ➞ [7, 14, 21, 28, 35]  
> arrayOfMultiples(12, 10) ➞ [12, 24, 36, 48, 60, 72, 84, 96, 108, 120]  
> arrayOfMultiples(17, 6) ➞ [17, 34, 51, 68, 85, 102]  
>   
> Notes  
> Notice that `num` is also included in the returned array.

# C#
> In this challenge, you must verify the equality of two different values given the parameters `a` and `b`.  
>   
> Both the *value* and *type* of the parameters need to be equal. The possible types of the given parameters are:
> - Numbers
> - Strings
> - Booleans (`true` or `false`)
>    
> What have you learned so far that will permit you to do two different checks (value **and** type) with a single statement?
>   
> Examples  
> CheckEquality(1, true) ➞ false // A number and a boolean: the value and type are different.  
> CheckEquality(0, "0")  ➞ false // A number and a string: the type is different.  
> CheckEquality(1,  1) ➞ true // A number and a number: the type and value are equal.  
>   
> Notes  
> Don't forget to return the result.

# JavaScript
> Write a function `redundant` that takes in a string `str` and returns a function that returns `str`.  
>   
> Examples  
> const f1 = redundant("apple")  
> f1() ➞ "apple"  
>   
> const f2 = redundant("pear")  
> f2() ➞ "pear"  
>   
> const f3 = redundant("")  
> f3() ➞ ""  
>
> Notes  
> Your function should return a **function**, not a string.

# Python
> Python got *drunk* and the built-in functions `str()` and `int()` are acting odd:  
> - str(4) ➞ 4  
> - str("4") ➞ 4  
> - int("4") ➞ "4"  
> - int(4) ➞ "4"  
>
> You need to create two functions to substitute `str()` and `int()`. A function called `int_to_str()` that converts **integers into strings** and a function called `str_to_int()` that converts **strings into integers**.  
>
> Examples  
> int_to_str(4) ➞ "4"  
> str_to_int("4") ➞ 4  
> int_to_str(29348) ➞ "29348"  
>
> Notes  
> - This is meant to illustrate the dangers of using already-existing function names.
> Extra points if you can **de-drunk** Python.