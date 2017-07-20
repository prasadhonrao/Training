import numpy

N, M, P = map(int, input().strip().split(' '))
first_array = []
second_array = []

for _ in range(N):
    arr = list(map(int, input().strip().split(' ')))
    first_array.append(arr)

for _ in range(M):
    arr = list(map(int, input().strip().split(' ')))
    second_array.append(arr)

print (numpy.concatenate((first_array, second_array), axis = 0))
