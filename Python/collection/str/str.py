# Declaration and concatenation
message1 = 'python ' + 'language 1'
print(message1)

# Declaration and concatenation
message1 = 'python ' 'language 2'
print(message1)

# Declaration and concatenation on separate line
message2 = 'python '
message2 += 'language 3'
print(message2)

# Multiline string using '''
message3 = '''python
           language 4'''
print(message3)

# String comparison
print(message1 == message2)
print(message1 is message2)

# Adding escape sequence
escape = 'Escape Sequence Character \' !!!'
print(escape)

# for path variables
systemPath = r'c:\Windows\System32'
print(systemPath)