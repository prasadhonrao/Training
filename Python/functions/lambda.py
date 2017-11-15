# double = lambda x : x * 2

# print(double(2))

# condition = lambda x : x > 1

# ls = [1, 2, 3]

import numpy as np

# np_ls = np.array(ls)

# print(type(condition(np_ls)))

# res = np_ls[condition(np_ls)]

# print(res)

ls = np.array([1, 2, 3])

ls_cond = np.([0, 1, 2])

res = ls[ls_cond]

print(res)
