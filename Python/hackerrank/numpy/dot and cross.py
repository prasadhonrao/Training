import numpy as np

n = int(input())

a = np.array([input().strip().split() for _ in range(n)], int)
b = np.array([input().strip().split() for _ in range(n)], int)

print(np.dot(a,b))