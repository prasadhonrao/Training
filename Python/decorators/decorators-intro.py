from pprint import pprint

a_global = 'global variable'

def foo():
    a_local = 'local variable'
    pprint(locals())

def foo1(x):
    pprint(locals())

# print(globals())
# foo()
foo1(10)