# declaration
languages = ["Python", "Scala", "Haskell", "F#"]
print(languages)

# iterate through the list
for i in languages:
    print(i, end=' -- ')
print(' ')

# declaration using list constructor
name = list("PYTHON")
print(name)

# multiline declaration 
languages = ['Python',
           'Scala',
           'Haskell',
           'F#']
print (languages)

# list length
print("number of chars in PYTHON : {0}".format(len(list("PYTHON"))))

# list methods
languages = ["Python", "Scala", "Haskell", "F#"]
print(languages)
print(languages[0:]) #slice till the end
print(languages[1:3])
print(languages[-2:])

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
