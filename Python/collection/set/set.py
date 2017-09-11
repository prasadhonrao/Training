# Unordered collection of unique and immutable objects

numbers = {10, 122, 343, 44, 5, 5, 10, 1}
print(numbers)
print(type(numbers))

emptySet = set() # do not initialize using {}, which actually initializes empty dictionary
print(type(emptySet))

for c in numbers:
    print(c) # printing order in set is not fixed

# membership check
print(10 in numbers)
print(100 not in numbers)

import itertools
top5 = itertools.islice({1, 2, 3, 4, 5, 6, 7}, 5)
for c in top5:
    print(c) # printing order in set is not fixed
