#!/bin/python3

import sys
from datetime import datetime

def time_delta(t1, t2):
    firstTime = datetime.strptime(t1,'%a %d %b %Y %H:%M:%S %z')
    secondTime = datetime.strptime(t2,'%a %d %b %Y %H:%M:%S %z')
    return int(abs((firstTime-secondTime).total_seconds()))

if __name__ == "__main__":
    t = int(input().strip())
    for a0 in range(t):
        t1 = input().strip()
        t2 = input().strip()
        delta = time_delta(t1, t2)
        print(delta)