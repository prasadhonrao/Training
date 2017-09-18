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

# Dictionary of dictionaries
europe = { 'spain': { 'capital':'madrid', 'population':46.77 },
           'france': { 'capital':'paris', 'population':66.03 },
           'germany': { 'capital':'berlin', 'population':80.62 },
           'norway': { 'capital':'oslo', 'population':5.084 } }


# Print out the capital of France
print(europe['france']['capital'])

# Create sub-dictionary data
data = {'capital':'', 'population':0}

# Add data to europe under key 'italy'
europe['italy'] = data

print(europe)

