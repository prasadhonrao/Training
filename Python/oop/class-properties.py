students = []

class Student:
    #constructor
    def __init__(self, name, id=0):
        self.name = name
        self.id = id
        students.append(self)

    #override toString
    def __str__(self):
        return "Student " + self.name.capitalize()

mark = Student("mark")
jack = Student("jack", 101)

print(mark)
print(jack)

print(students)