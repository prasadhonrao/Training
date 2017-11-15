import numpy as np

numbers = [1, 2, 3] # normal list

numbers2 = np.array(numbers) # numpy array

print(numbers + numbers)
print(numbers2 + numbers2)


# Generate numpy array using rand

my_random_array = np.random.rand(3)
print(my_random_array)
