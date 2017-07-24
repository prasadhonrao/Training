import numpy as np

n = int(input())
A = np.array([input().split() for _ in range(n)], float)

print(np.linalg.det(A))