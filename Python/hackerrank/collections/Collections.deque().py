from collections import deque

N = int(input())
dq = deque()

for _ in range(N):
    cmd, *args = input().split()
    getattr(dq, cmd)(*args)

print(*dq)