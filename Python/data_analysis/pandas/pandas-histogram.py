import pandas as pd
from matplotlib import pyplot as plt

countries = pd.read_csv(r'D:\Git\Training\Python\assets\csv\countries.csv')

# print(countries.head())

# print(set(countries.cont))

countries_2007 = countries[countries.year == 2007]
# print(countries_2007)

countries_asia_2007 = countries_2007[countries_2007.cont == "Asia"]
countries_europe_2007 = countries_2007[countries_2007.cont == "Europe"]

print(countries_asia_2007.head())
print(countries_europe_2007.head())
