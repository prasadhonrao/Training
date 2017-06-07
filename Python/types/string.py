# declaration using single quote
messasge = 'Python is one of the most amazing languages!'
print(messasge)

# declaration using single quote
messasge = "Python is one of the most amazing languages!"
print(messasge)

# escape sequence
message = 'You can put an escape sequence \' easily'
print(message)

# declaration using r (raw string which does not automatically escape \ etc)
path = r'c:\windows\system32'
print(path)

# declaration using str type
message = str("this is a messsage")
print(message)
print(type(message))

# Methods
print("this is a capitalized text".capitalize() )
print("hello".replace("e","a"))
print("python".isalpha())
print("123".isdigit())
print(("red, green, blue").split(","))

#string interpolation
name = "Prasad"
machine = "Windows"
print("{0} is using {1} machine".format(name, machine))
print(f"{name} is using {machine} machine")

