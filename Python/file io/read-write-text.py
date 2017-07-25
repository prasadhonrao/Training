#write a file
f = open('aboutme.txt', 'wt', encoding='utf-8')

f.write('My name is Prasad Honrao \n')
f.write('I\'m a language enthusiast')
f.close()

#read a file
g = open('aboutme.txt', 'rt')
print(g.read())
g.close()

#read all the lines from a file into a list
g = open('aboutme.txt', 'rt')
print(g.readlines())
g.close()
