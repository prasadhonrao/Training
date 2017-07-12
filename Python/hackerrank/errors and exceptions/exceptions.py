if __name__ == '__main__':
    n = int(input())
    eq = []
    for _ in range(n):
        eq.append(input().split())
    
    for e in eq:
        try:
            print(int(e[0]) // int(e[1]))
        except (ZeroDivisionError, ValueError) as e:
            print ("Error Code:",e)