# 1. Gotcha 
# Single element tuple needs to be declared either using trailing comma 
# or tuple constructor

t = (123) # here t will be considered as of type int
print(type(t))

t = (123, ) # now its tuple
print(type(t))

# declare tuple using constructor
t = tuple('Prasad')
print(type(t))