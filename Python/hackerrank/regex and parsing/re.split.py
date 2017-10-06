import re

print(*re.split("[,.]+", input()), sep="\n")

[print(i) for i in re.split('[.,]', input()) if i]

for item in re.split("[,.]",input()):
    print(item, end='\n')

print(*filter(None, re.split(r'[.,]+', input())), sep='\n')