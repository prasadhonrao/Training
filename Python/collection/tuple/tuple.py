# tuples are declared using () and elements are separated using comma
# tuples are immutable

t = ("Prasad", "Honrao", 37, "Pune")
print (t)

# access tuple element using indexer
print('First element in tuple is' , t[0])

# find tuple length using len
print('Tuple lenght is ', len(t))

# iterate through tuple
for item in t:
    print(item, end=' ')
print('')

# concatenate tuple using +
t = t + ('Programmer', 'Cognizant')
print(t)

# declare empty tuple
e = ()
print(type(e))

e = e + t
print(e)

# tuple in a function
def minmax(items):
    return min(items), max(items)

# tuple as return value
lower, upper = minmax([1,2,3,4,5,6,7,8,9,10])
print(lower, upper)

# declare tuple using constructor
c = tuple('Prasad')
print (c)

# element exist check
print ( 5 in (1, 2, 3, 4, 5))
print ( 6 not in (1, 2, 3, 4, 5))