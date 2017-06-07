student = {
    "firstName":"Prasad",
    "lastName":"Honrao",
    "age": 37
}

try:
    #try to get wrong value from dictionary
    last_name = student["last_name"]
except KeyError:
    print("Exception thrown!")

print("Done!")