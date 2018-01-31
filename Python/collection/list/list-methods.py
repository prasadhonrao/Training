# list methods
languages = ["Python", "Scala", "Haskell", "F#"]
print(languages)

#slice
print(languages[0:]) #slice till the end
print(languages[1:3])
print(languages[-2:])

# reverse a list using slice
print(languages[::-1])

# append to list
languages = ["Python", "Scala", "Haskell", "F#"]
languages.append("Clojure")
print(languages)

# copy list using slice
functional_languages = languages[:]
print(functional_languages)

print(languages == functional_languages)
print(languages is functional_languages)

# copy list using copy
functional_languages = languages.copy()

# copy list using constructor
functional_languages = list(languages)

# element exists check
languages = ["Python", "Scala", "Haskell", "F#"]
print("Python" in languages)
print("C#" in languages)

# delete an element
languages = ["Python", "Scala", "Haskell", "F#"]
del languages[0]
print("Python exist? {0}".format("Python" in languages))

# List sort

# Create lists first and second
first = [11.25, 18.0, 20.0]
second = [10.75, 9.50]

# Paste together first and second: full
full = first + second

# Sort full in descending order: full_sorted
full_sorted = sorted(full, reverse=True)

# Print out full_sorted
print(full_sorted)