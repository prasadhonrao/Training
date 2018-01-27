true = True
false = False

print (true is True)
print (false is True)

# Trythy Falsy Check

# Any value other than integer 0 (including negative value) is Truthy
print("Integer 1 boolean value = {}".format(bool(1)))
print("Negative integer 1 boolean value = {}".format(bool(-1)))
print("Float boolean value = {}".format(bool(1.23)))
print("Zero boolean value = {}".format(bool(0)))

print("Non empty string with space boolean value = {}".format(bool('SPAM')))
print("Empty string boolean value = {}".format(bool('')))

# Any empty collection is treated as Falsey
print("Empty collection bool value = {}".format(bool([])))
print("Filled collection bool value = {}".format(bool([1, 2, 3])))

# print(type(str(true)))