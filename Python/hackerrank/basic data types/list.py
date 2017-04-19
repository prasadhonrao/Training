outputList = []
N = input()
for n in range(0, int(N), 1):
    inputs = input().split()
    if (inputs[0] == 'print'):
        print(outputList)
    elif (inputs[0] == 'insert'):
        outputList.insert(int(inputs[1]), int(inputs[2]))
    elif (inputs[0] == 'remove'):
        outputList.remove(int(inputs[1]))
    elif inputs[0] == "sort":
        outputList.sort()
    elif inputs[0] == "append":
        outputList.append(int(inputs[1]))
    elif inputs[0] == "reverse":
            outputList.reverse()
    elif inputs[0] == "pop":
            del outputList[-1]    
        
