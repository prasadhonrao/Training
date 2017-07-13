students = []
class Student:
    #constructor
    def __init__(self, name, id=0):
        s = {"name" : name, "id" : id}
        students.append(s)

    #override toString
    def __str__(self):
        return "Overridden method"

mark = Student("Mark", 10)
print(mark)
print(students)