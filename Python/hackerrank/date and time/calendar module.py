import calendar

# input format is MM DD YYYY
m, d, y = map(int, input().split())

print(str(calendar.day_name[calendar.weekday(y, m, d)]).upper())