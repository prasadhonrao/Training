def add(first, second):
    return first + second

print(add(10, 20))
print(str(add(1,2)))
print(str(add(1.2,2.3)))
print(add('news', 'paper'))

# datatype can be specific which gets used only to provide type information in IDE
def add2(first:int, second:int) -> int:
    return first + second

print(add2(10,20))