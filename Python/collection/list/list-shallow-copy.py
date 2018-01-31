a = [[1, 2], [3, 4]]
print ("a = ", a)

b = a[:]
print ("b = ", b)

print ("a is b ->", a is b)
print ("a == b ->", a == b)
print ("a[0] == b[0] ->", a[0] == b[0])
print ("a[0] is b[0] ->", a[0] is b[0])

a[0] = [8, 9]
print ("a = ", a)
print ("b = ", b)

a[1].append(5)
print ("a = ", a)
print ("b = ", b)



