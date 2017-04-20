s1 = 'new' + 'found' + 'land'
print(s1)

s2 = 'new'
s2 += 'found'
s2 += 'land'
print(s2)

print(s1 == s2)
print(s1 is s2)

# join method
s3 = ' -- '.join(['prasad','subhash','honrao'])
print(s3)

# partition method, it returns tuple
s4 = 'prasadsubhashhonrao'.partition('subhash')
print(s4)