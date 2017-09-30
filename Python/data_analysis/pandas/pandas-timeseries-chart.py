import pandas as pd
from matplotlib import pyplot as plt

data = pd.read_csv(r'D:\Git\Training\Python\assets\csv\countries_gdp.csv')

# print(data)

us = data[data.country == "United States"]
china = data[data.country == "China"]

plt.title("Population grown in US and China in millions")
plt.xlabel("Year")
plt.ylabel("Population")
plt.legend(['United States', 'China'])

plt.plot(us.year, us.population)
plt.plot(china.year, china.population)
plt.show()