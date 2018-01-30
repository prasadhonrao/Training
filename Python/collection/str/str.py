# Declaration and concatenation
message1 = 'python ' + 'language 1'
print(message1)

# Declaration and concatenation
message2 = 'python ' 'language 2'
print(message2)

# Declaration and concatenation on separate line
message3 = 'python '
message3 += 'language 3'
print(message3)

# Multiline string using '''
message4 = '''python
           language 4'''
print(message4)

# Adding escape sequence
escape = 'Escape Sequence Character \' !!!'
print(escape)

# for path variables
systemPath = r'c:\Windows\System32' # r prefix indicates raw string
print(systemPath)

# String comparison
print(message1 == message2)
print(message1 is message2)
