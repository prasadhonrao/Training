# Install matplotlib module using following commands. Use administrative mode!
# pip install matplotlib

import matplotlib.pyplot as plt
# from matplotlib import pyplot as plt     # recommended way of importing package

year = [1950, 1970, 1990, 2010]
population = [2.159, 3.692, 5.263, 6.972]

# add chart metadata like title and axis

plt.xlabel('Year')
plt.ylabel('Population')
plt.title('World Population Projection')

# plt.plot(year, population)  #line chart
plt.scatter(year, population) #scatter chart

plt.show()