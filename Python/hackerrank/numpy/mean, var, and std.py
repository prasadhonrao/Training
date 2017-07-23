import numpy

N, M = map(int, input().split(' '))
A = numpy.array([list(input().strip().split())[:M] for _ in range(N)],int)

print(numpy.mean(A, axis=1))
print(numpy.var(A, axis=0))
print(numpy.std(A, axis=None))
