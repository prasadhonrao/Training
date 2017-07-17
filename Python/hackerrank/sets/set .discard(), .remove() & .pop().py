n = int(input())
s = set(map(int, input().split())) 

tries = int(input())

for i in range(tries):
    choice = input().split()
    if (choice[0] == "pop"):
        s.pop()
    elif choice[0]=="remove" :
        s.remove(int(choice[1]))
    elif choice[0]=="discard" :
        s.discard(int(choice[1]))

print(sum(s))

# s = {1, 2, 3, 4, 5}
# eval("s.pop()")
# eval("s.remove(2)")
# eval("s.discard(3)")

# print(s)