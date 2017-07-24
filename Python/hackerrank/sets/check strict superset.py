s = set(map(int, input().split(' ')))
res = "True"
r = int(input())
for _ in range(r):
    t = set(map(int, input().split(' ')))
    if s.issuperset(t):
        res = "True"
    else:
        res = "False"
        break

print(res) 