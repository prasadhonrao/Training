message = b'I got few bytes'
print("{0}".format(message))
print("{0}".format(len(message)))

val = "Καλημέρα κόσμε"
data = val.encode('utf-8') # encode string to byte array
print(data)

decoded = data.decode('utf-8') # decode byte to string
print(decoded)