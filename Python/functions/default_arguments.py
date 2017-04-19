# Greet function which has default message as hello
def greet(user, message = 'hello'):
    print(message + ' ' + user)

greet('Prasad')
greet('Prasad', 'Howdy')


# Another example of default argument to print banner
def printBanner(message, border='-'):
    line = border * len(message)
    print(line)
    print(message)
    print(line)

printBanner('Python is dynamic')
printBanner('It really is!', '*')
printBanner(border='.', message='Parameters swapped')