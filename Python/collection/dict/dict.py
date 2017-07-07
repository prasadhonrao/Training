# dictionary key can have different data types, including nested dictionary
customers = { 
                1: 'Prasad', 
                2: 'Amit', 
                3: 'Scott',
                "four": 4 
            }
print(type(customers))
print(customers)
print(customers[1])
print("Dictionary length is {0}".format(len(customers)))
print(customers.keys()) #get all keys
print(customers.values()) # get all values

print(customers[1].values())

# use get method to get a value using key, and pass default value if key doesn't exists in the dictionary
first = customers.get('11', 'unknown value')
print(first)

# add new key to dictionary
customers['11'] = "Eleven"
first = customers.get('11', 'unknown value')
print(first)


dictionaryList = [
    {"firstName": "Prasad", "lastName": "Honrao"},
    {"firstName": "Scott", "lastName": "Hanselman"},
    {"firstName": "Bill", "lastName": "Gates"}
]

print(dictionaryList)