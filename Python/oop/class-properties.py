students = []

class Student:
    #constructor
    def __init__(self, name, id=0):
        self.name = name
        self.id = id
        students.append(self)

    #override toString
    def __str__(self):
        return "Student {0}'s id is {1} and age is {2}".format(self.name.capitalize(), self.id, self.age)

    #define age property
    def age(self, age):
        selg.age = age

mark = Student("mark")
jack = Student("jack", 101)

mark.age = 25
jack.age = 33

print(mark)
print(jack)

print(students)