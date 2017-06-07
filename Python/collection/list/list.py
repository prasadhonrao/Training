# declaration
numbers = [1, 2, 3]
print(numbers)

# iterate through the list
for i in numbers:
    print(i, end=' ')
print(' ')

# declaration using list constructor
name = list("PYTHON")
print(name)

# multiline declaration 
animals = ['dog',
           'cat',
           'mouse']
print (animals)

# list length
print("number of chars in PYTHON : {0}".format(len(list("PYTHON"))))

# list methods
words = "python is one of the most powerful languages".split()
print(words)
print(words[0:]) #slice till the end
print(words[1:3])
print(words[-5:])

# append to list
words = "python is one of the most powerful languages".split()
words.append("it's true")
print(words)

# copy list using slice
same_words = words[:]
print(same_words)

print(words == same_words)
print(words is same_words)

# copy list using copy
v = words.copy()

# copy list using constructor
v1 = list(v)

# element exists check
students = ["Prasad", "Mark", "Susan"]
print("Prasad" in students)
print("Jack" in students)