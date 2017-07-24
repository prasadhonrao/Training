import numpy as np

A = np.array(input().split(), float)
B = float(input())

print(np.polyval(A, B))