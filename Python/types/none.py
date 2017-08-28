# Python never prints None value
print(None)

isNone = None
print(isNone is None) # Check for None using 'is' operator

# None to check in boolean condition
if(None):
    print("None is Truthy")
else:
    print("None is Falsy")