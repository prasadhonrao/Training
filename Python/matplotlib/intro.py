# Install matplotlib module using following commands. Use administrative mode!
# pip install matplotlib

import matplotlib.pyplot as plt

year = [1950, 1970, 1990, 2010]
population = [2.159, 3.692, 5.263, 6.972]

# plt.plot(year, population)  #line chart
plt.scatter(year, population) #scatter chart

plt.show()