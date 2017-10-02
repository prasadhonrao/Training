# An OrderedDict is a dictionary that remembers the order of the keys that were inserted first. 
# If a new entry overwrites an existing entry, the original insertion position is left unchanged.

from collections import OrderedDict
import random

od = OrderedDict()
for f in ['Orange', 'Banana', 'Mango', 'Cherries']:
    od[f] = random.randint(50, 100)

print(od)

od['Banana'] = 100

print(od) #order remains same

od.move_to_end('Banana') # move key to end

print(od)

# remove item using popitem
print(od.popitem())
print(od)
