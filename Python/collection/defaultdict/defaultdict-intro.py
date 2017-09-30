# defaultdict - extension to existing dict collection
# 1. Can maintain order of keys which you may or maynot want
# 2. Can provide default values for a key depending on data type or a factory function

from collections import defaultdict

str_dict = defaultdict(str)
print(str_dict['foo'])

int_dict = defaultdict(int)
print(int_dict[100])

bool_dict = defaultdict(bool)
print(bool_dict['hi'])

# add items
str_dict = defaultdict(str)
str_dict['apples'] = 10
print(str_dict['apples'])

# default value using a custom class
class Fraction(object):
    def __init__(self):
        self.n = 1
        self.d = 2
    def __repr__(self):
        return '{0}/{1}'.format(self.n, self.d)

fract_dict = defaultdict(Fraction)
print(fract_dict[100])

# default value using factory function
def dne():
    return "DNE"

dne_dict = defaultdict(dne)
print(dne_dict[100])