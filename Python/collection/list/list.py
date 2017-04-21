numbers = [1, 2, 3]
print(numbers)

for i in numbers:
    print(i, end=' ')
print(' ')

name = list("PYTHON")
print(name)

animals = ['dog',
           'cat',
           'mouse']
print (animals)

words = "python is one of the most powerful languages".split()
print(words)
print(words[0:]) #slice till the end
print(words[1:3])
print(words[-5:])

# copy list using slice
same_words = words[:]
print(same_words)

print(words == same_words)
print(words is same_words)

# copy list using copy
v = words.copy()

# copy list using constructor
v1 = list(v)