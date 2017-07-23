import numpy

# my_array = numpy.array([[2, 5], 
#                         [3, 7],
#                         [1, 3],
#                         [4, 0]])

# print(numpy.min(my_array, axis = 0))      #Output : [1 0]
# print(numpy.min(my_array, axis = 1))      #Output : [2 3 1 0]
# print(numpy.min(my_array, axis = None))      #Output : 0
# print(numpy.min(my_array))      #Output : 0

N, M = map(int, input().split(' '))
A = numpy.array([list(input().strip().split())[:M] for _ in range(N)],int)
print(numpy.max(numpy.min(A, axis=1), axis=0))