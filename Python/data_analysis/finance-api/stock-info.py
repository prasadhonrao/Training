import urllib.request
from pprint import pprint

url = "https://www.quandl.com/api/v3/datasets/WIKI/FB/data.csv?api_key=6wQF54H2edbzVxxoMrMN"

raw_data = urllib.request.urlopen(url).read().decode('utf-8')
split_source = raw_data.split("\n")


# Read and Print data

for eachLine in split_source:
    split_line = eachLine.split(",")
    if (len(split_line[0]) == 10): # check for first date column length
        print(split_line)

# Write to CSV

with open('data2.csv','w') as file:
    for line in split_source:
        file.write(line)
        file.write('\n')
