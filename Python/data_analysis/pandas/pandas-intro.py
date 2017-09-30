# Note
# 
# 2D Numpy Array can hold values only of one dayatype. Pandas does not have that
# restriction and is ideal data structure for tabular data which has columnn values 
# with multiple data types
# 

import pandas as pd

# Create Panda dataframe using dictionary

dict = {
    "country" : ["Brazil", "Russia", "India", "China", "South Africa"],
    "capital": ["Brasilia", "Moscow", "New Delhi", "Beijing", "Pretoria"],
    "area": [8.516, 17.100, 3.286, 9.597, 1.221],
    "population": [200.4, 143.5, 1252, 1357, 52.98]
}

brics = pd.DataFrame(dict)

# brics = pd.read_csv(r"d:\git\training\python\assets\csv\brics.csv")

print(brics)

brics.index = ["BR", "RU", "IN", "CH", "SA"]

print(brics)