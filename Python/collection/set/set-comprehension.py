from math import factorial

l = [len(str(factorial(x))) for x in range(20)] # this is a list using []
s = {len(str(factorial(x))) for x in range(20)} # set using {}

print(l)
print(s)