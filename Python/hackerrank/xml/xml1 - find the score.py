import xml.etree.ElementTree as etree

# from pprint import pprint

numlines = int(input())

XML = ''

for _ in range(numlines):
    XML += input()

# pprint(XML)    

root = etree.fromstring(XML)

# pprint(root)

print (sum(len(i.attrib) for i in root.iter()))