from collections import OrderedDict

N = int(input())
basket = OrderedDict()

# rpartition : 
# Returns a tuple containing the left part of the string split by the specified separator, 
# the separator itself and the right part of the string (starting from right).

for i in range(N):
    item, space, quantity = input().rpartition(' ')
    basket[item] = basket.get(item, 0) + int(quantity)

# print basket
for item, quantity in basket.items():
    print(item, quantity)