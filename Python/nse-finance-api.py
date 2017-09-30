# pip install nsetools

from nsetools import Nse
from pprint import pprint

nse = Nse()
print(nse)

q = nse.get_quote('infy')
pprint(q)

