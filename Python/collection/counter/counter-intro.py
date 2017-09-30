# Counter collection has almost similar APIs as dict, and can be used as a replacement to it

from collections import Counter

# empty counter
c = Counter()

c["apples"] += 1
c["bananas"] += 10
c["apples"] += 5
c["cherries"] += 2

print(c.most_common()) #displays items with sorted list of its count
print(c['lemons']) #default to 0 if element doesnt exists

# counter initialization using list
fruits = ['apple', 'banana', 'cherries', 'mango']
fruits_counter = Counter(fruits)

for item in fruits_counter.elements():
    print(item)