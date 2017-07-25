A = input()
s1 = set(input().split())
group = int(input())

for i in range(group):
    eval('s1.{0}({1})'.format(input().split()[0], input().split()))

print(sum(map(int, s1)))