import math
print("square root of 81 = {} ".format(math.sqrt(81)))

# import one specific function from module
from math import factorial
print("10 factorial value = {} ".format(math.factorial(10)))

# alias
from math import factorial as fac
print("5 factorial value = {} ".format(fac(5)))

print(fac(6) / fac(2) )  # returns float result
print(fac(6) // fac(2) ) # // converts float into int

# built in math e and pi values
print("e value = {} ".format(math.e))
print("Pi value = {} ".format(math.pi))