from collections import OrderedDict

dict = OrderedDict()

for _ in range(int(input())):
    key = input()
    if not key in dict.keys():
        dict.update({key : 1})
    else:
        dict[key] += 1

print(len(dict.keys()))
print(*dict.values())