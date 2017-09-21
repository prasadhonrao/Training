import numpy as np

height = [1.73, 1.68, 1.71, 1.89, 1.79]
weight = [65.4, 59.2, 63.6, 88.4, 68.7]

# this call throws an exception cox pow function is not available on list
# bmi = weight / height ** 2 

# convert list to numpy array

np_height = np.array(height)
np_weight = np.array(weight)
bmi = np_weight / np_height ** 2

print(bmi)
print(type(bmi))