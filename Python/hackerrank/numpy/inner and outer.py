import numpy as np

a = np.array(input().strip().split(), int)
b = np.array(input().strip().split(), int)

print(np.inner(a,b))
print(np.outer(a,b))
