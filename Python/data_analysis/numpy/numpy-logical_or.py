import numpy as np

numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10] # normal list

numbers2 = np.array(numbers) # numpy array

print(np.logical_or(numbers2 > 3, numbers2 <= 6 ))
print(numbers2[np.logical_or(numbers2 > 3, numbers2 <=6 )])
