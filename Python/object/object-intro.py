# int object is immutable
age = 30
print(id(age)) # id is used to get a object reference id

age = 40
print(id(age))

# list is mutable
series1 = [1, 2, 3]
series2 = series1
print(id(series1))
print(id(series1))

series1[1] = 10
print(series1)
print(series2)
print(id(series1))
print(id(series1))

# is operator can be used for object equality
series1 = [1, 2, 3]
series2 = [1, 2, 3]
print(series1 is series2) # reference equality
print(series1 == series2) # value equality



