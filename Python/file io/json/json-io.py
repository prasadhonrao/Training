import json

data = {
    'sales': [
        {'day' : 'Monday', 'revenue' : 100},
        {'day' : 'Tuesday', 'revenue' : 50},
        {'day' : 'Wednesday', 'revenue' : 80},
        {'day' : 'Thursday', 'revenue' : 120},
        {'day' : 'Friday', 'revenue' : 20},
        {'day' : 'Saturday', 'holiday' : True},
        {'day' : 'Sunday', 'holiday' : True},
    ],
    'expense': 14.99,
    'fires' : None
}

# write data
s = json.dumps(data)
print(s)

# read data
read_data = json.loads(s)
print(read_data)
# print(sum([day for day in read_data['sales'] if 'revenue' in day.keys()]))

