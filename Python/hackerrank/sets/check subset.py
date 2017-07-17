# print({1, 2, 3, 10}.issubset({1, 2, 3, 4}))

for i in range(int(input())): #More than 4 lines will result in 0 score. Blank lines won't be counted. 
    a = int(input()); A = set(input().split()) 
    b = int(input()); B = set(input().split())
    print("True" if A.issubset(B) else "False")