# Method - Capitalize
print('python'.capitalize())

# Method - Join 
print ('--'.join('[1, 2, 3, 4, 5]'))

# Method - Partition -> Returns 3 part string seperated by seperator. 
# It returns tuple
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
s1 = s[:] # creating a copy of string
print(s1)

# Format
print("My full name is {0} {1}".format('Prasad', 'Honrao'))
print("My full name is {firstname} {lastname}".format(firstname = 'Prasad', lastname = 'Honrao'))
