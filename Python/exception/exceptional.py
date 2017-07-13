'''A module for demonstrating exception'''

import sys

def convert(s):
    '''Convert to an integer.'''
    try:
        return int(s)
    except (ValueError, TypeError) as e:
        print("Conversion error : {}".format(str(e)), file=sys.stderr)
        raise
    finally:
        print("done!")

convert("10")
convert("10A")
