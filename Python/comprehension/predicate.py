def is_even(x):
    if (x % 2 == 0):
        return True
    return False

print([x for x in range(100) if is_even(x)])