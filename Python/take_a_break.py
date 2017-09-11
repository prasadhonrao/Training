import webbrowser
import time

total_breaks = 3
break_count = 0

while (break_count < total_breaks):
    print("Program started on " + time.ctime())
    time.sleep(10) # 10 seconds
    webbrowser.open('https://www.youtube.com/watch?v=-qlJiGGvPUI')
    break_count += 1
