# tuple in a function
def minmax(items):
    return min(items), max(items)

# tuple as return value
lower, upper = minmax([1, 2, 3, 4, 5, 6, 7, 8, 9, 10])
print(lower, upper)

# element swapping using tuple
a = '1'
b = '2'
print('Before swap : ' + a + " " + b )
a, b = b , a
print('After swap : ' + a + " " + b )