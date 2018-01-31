numbers = [1, 2, 3]

def modify(list):
    list.append(4) # Note we are updating existing list here
    print("list = ", list)

modify(numbers)
print("numbers = ", numbers)

numbers2 = [1, 2, 3]

def modify2(list):
    list = [10, 20, 30] # reinitializing list
    print("list = ", list)

modify2(numbers2)
print("numbers = ", numbers2)

