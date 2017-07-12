text = "The quick brown fox jumps over a lazy dog"
words = text.split()

# Find length of each word in the sentence
print([len(word) for word in words])

# Capitalize each word
print([str(word).capitalize() for word in words])

#print(words)