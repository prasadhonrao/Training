messasge = 'Python is one of the most amazing languages!'

print(messasge)

messasge = "Python is one of the most amazing languages!"

print(messasge)

message = 'You can put an escape sequence \' easily'

print(message)

path = r'c:\windows\system32'
print(path)

message = str("this is a messsage")
print(message)
print(type(message))

# Methods
text = message.capitalize() # capitalize first letter
print(text)

text = "hello".replace("e","a")
print(text)

print("python".isalpha())

print("123".isdigit())

print(("red, green, blue").split(","))

#string interpolation
name = "Prasad"
machine = "Windows"
print("{0} is using {1} machine".format(name, machine))
print(f"{name} is using {machine} machine")

