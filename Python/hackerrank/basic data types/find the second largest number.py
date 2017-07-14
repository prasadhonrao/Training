if __name__ == '__main__':
    n = int(input())
    arr = map(int, input().split())
    sortedSet = sorted(set(arr)) # convert to set to remove duplicate
    if len(sortedSet) > 1: # this condition is required to check if sorted set contains more than 1 item for e.g. for input 0 0 0 0 0
        print(sortedSet[-2])
    else: 
        print(sortedSet[0])    