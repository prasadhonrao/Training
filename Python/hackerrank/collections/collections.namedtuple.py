from collections import namedtuple

n = int(input()) #number of students
column_names = input().split()
total = 0

for i in range(n):
    Student = namedtuple('Student', column_names)
    field1, field2, field3, field4 = input().split()
    student = Student(field1,field2,field3,field4)
    total += int(student.MARKS)

print('{:.2f}'.format(total/n))