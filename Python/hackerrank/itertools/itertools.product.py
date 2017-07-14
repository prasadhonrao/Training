from itertools import product

first = list(map(int, input().split()))
second = list(map(int, input().split()))

# (a, b, c, d) = (list(product(first, second)))
# print(a, b, c, d)

print(*product(first, second))