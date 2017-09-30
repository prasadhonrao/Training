from matplotlib import pyplot as plt

plt.xlabel("X Axis")
plt.ylabel("Y Axis")
plt.title("Random chart")

plt.plot([1, 2, 3, 4], [4, 5, 3.3, 6])
plt.plot([1, 2, 3, 4], [40, 50, 33, 6])

plt.legend(['Set 1', 'Set 2'])

plt.show()

plt.savefig('randomchart')
