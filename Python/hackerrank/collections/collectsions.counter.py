# A counter is a container that stores elements as dictionary keys, and their 
# counts are stored as dictionary values.
from collections import Counter

myList = [1,1,2,3,4,5,3,2,3,4,2,1,2,3]

print (Counter(myList))
print (Counter(myList).items())
print (Counter(myList).keys())
print (Counter(myList).values())