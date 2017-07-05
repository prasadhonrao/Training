# Truty Falsy Rule
# Any number other than 0 is true
# Any string other than empty string is true
# None is falsy value

if True:
    print("This will be printed")

if False:
    print("This will not be printed")

if (bool(0)):
    print("This will not be printed as zero is false")

if (bool("0")):
    print("This will be printed as zero is a string here")

if (not None):
    print("None is a falsy value")

number = 100
if number > 10:
    print("Input number is greater than 10")
else:
    print("Input number is less than 10")

number = 10
if number > 100:
    print("Greater than 100")
elif number > 50:
    print("Greater than 10")
else:
    print("Less than 50")
    