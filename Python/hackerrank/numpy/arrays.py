import numpy

def arrays(arr):
    arr = numpy.array(arr, float)
    reversed_arr = arr[::-1]
    return reversed_arr

arr = input().strip().split(' ')
result = arrays(arr)
print(result)
