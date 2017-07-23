import numpy
# my_array = numpy.array([ [1, 2], [3, 4] ])
# print(numpy.sum(my_array, axis = 0))      #Output : [4 6]
# print(numpy.sum(my_array, axis = 1))      #Output : [3 7]
# print(numpy.sum(my_array, axis = None))      #Output : 10
# print(numpy.sum(my_array))      #Output : 10

N, M = map(int, input().split(' '))
A = numpy.array([list(input().strip().split())[:M] for _ in range(N)],int)
print(numpy.prod(numpy.sum(A, axis=0), axis=0))