import numpy

arr = input().strip().split(' ')
arr = numpy.array(arr, int)
print (numpy.reshape(arr,(3,3)))
