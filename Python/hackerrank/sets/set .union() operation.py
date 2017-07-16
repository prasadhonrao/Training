# s1 = {1, 2, 3, 4, 5, 6, 7, 8, 9}
# s2 = {10, 1, 2, 3, 11, 21, 55, 6, 8}
# print(s1.union(s2))

n = int(input())
s1 = set(map(int, input().split()))

m = int(input())
s2 = set(map(int, input().split()))

print(len(s1.union(s2)))