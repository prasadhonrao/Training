import string

# def capitalize(input):
#     return string.capwords(input)

def capitalize(string):
    for x in string[:].split():
        string = string.replace(x, x.capitalize())
    return string

print(capitalize('hello world'))
print(capitalize('Hello World'))
print(capitalize('Hello    World'))
print(capitalize('123K'))
print(capitalize('123k'))
print(capitalize('!@#$'))
print(capitalize('k'))
print(capitalize('1 w 2 r 3g'))
print(capitalize('uttu123\'s answer is wrong'))

