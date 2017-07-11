def average(array):
    return sum(set(array)) / len(set(array))

array = [161, 182, 161, 154, 176, 170, 167, 171, 170, 174]

print (average(array))