# Capitalize
print('python'.capitalize())

# Format
print("My full name is {0} {1}".format('Prasad', 'Honrao'))
print("My full name is {firstname} {lastname}".format(firstname = 'Prasad', lastname = 'Honrao'))

# Join 
print ('*'.join(['1', '2', '3', '4', '5']))

# Partition -> Returns 3 part string seperated by seperator. It returns a tuple.
print("unforgettable".partition("forget"))

# Split
s = "Python is extremely powerful language".split()
print(s)

# Slice
s = "Python is extremely powerful language".split()
print(s[0])
print(s[1:4])
print(s[1:-1])
print(s[2:])
print(s[:2])

# creating a copy of string
s1 = s[:] 
print(s1)
