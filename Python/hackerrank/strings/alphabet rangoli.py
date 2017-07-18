import string
alpha = string.ascii_lowercase #contains all lowercase characters

n = int(input())
line = []
for i in range(n):
    s = "-".join(alpha[i:n])
    line.append((s[::-1]+s[1:]).center(4*n-3, "-"))
print('\n'.join(line[:0:-1]+line))