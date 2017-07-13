import itertools

n = int(input())
a = set(itertools.islice((input().split()), n))

m = int(input())
b = set(itertools.islice((input().split()), m))

common = sorted(set(map(int, (a.difference(b)).union(b.difference(a)))))
for number in common:
    print(number, sep='\n')
