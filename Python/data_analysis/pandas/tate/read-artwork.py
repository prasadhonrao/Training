import pandas as pd
import os

CSV_PATH = os.path.join('..\\..\\..\\assets\\tate','artwork_data.csv')
# print(CSV_PATH)

# index_col :  use id as indexed column instead of auto generated 1, 2, 3...
# usecols : select only specified columns

COLS_TO_USE = ['id', 'artist', 'title', 'medium', 'year', 'acquisitionYear', 'height', 'width', 'units']

df = pd.read_csv(CSV_PATH, nrows=5, index_col='id', usecols= COLS_TO_USE) 
print(df)

# serialize data using to_pickle for later usage
# df.to_pickle(os.path.join('..\\..\\..\\assets\\tate', 'data_frame.pickle'))