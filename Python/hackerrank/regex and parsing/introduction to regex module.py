# A regular expression (or RegEx) specifies a set of strings that matches it.
# A regex is a sequence of characters that defines a search pattern, mainly for 
# the use of string pattern matching.

import re

for _ in range(int(input())):
    print(bool(re.match("^[\+-]?\d*\.\d+$", input())))