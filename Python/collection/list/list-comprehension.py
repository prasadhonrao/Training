# General comprehension syntax : [ expr (item) for item in interable]

text = "The quick brown fox jumps over a lazy dog"
words = text.split()

# Problem statement - find length of each word in the sentence

# Without comprehension
lengths = []
for word in words:
    lengths.append(len(word))

# With comprehension
print([len(word) for word in words])

print(lengths)

# Capitalize each word
print([str(word).capitalize() for word in words])

# Calculate length of factorial upto 20 digits
from math import factorial
f = [len(str(factorial(x))) for x in range(20)]
print(f)