# The defaultdict tool is a container in the collections class of Python. It's similar to the usual dictionary (dict) container, but it has one difference: 
# The value fields' data type is specified upon initialization. 

# from collections import defaultdict

# d = defaultdict(list)

# d['python'].append("awesome")
# d['something-else'].append("not relevant")
# d['python'].append("language")

# for i in d.items():
#     print (i)

from collections import defaultdict
d = defaultdict(list)
list1=[]

n, m = map(int,input().split())

for i in range(0,n):
    d[input()].append(i+1) 

for i in range(0,m):
    list1=list1+[input()]  

for i in list1: 
    if i in d:
        print (" ".join( map(str,d[i]) ))
    else:
        print (-1)
