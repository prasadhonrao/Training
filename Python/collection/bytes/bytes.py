val = 'some bytes'

data = val.encode('utf-8') # encode string to byte array
print(data)
print(len(data))

decoded = data.decode('utf-8') # decode byte to string
print(decoded)