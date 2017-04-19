first = 100
print(id(first))

second = 100
print(id(second))

first = 200
print(id(first))

third = first
print(id(third))

print (first is third)
