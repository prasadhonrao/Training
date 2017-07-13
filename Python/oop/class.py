class Student:
    pass

student1 = Student()
student2 = Student()
print("Class id - " , student1)
print("Class id - " , student2)
print(type(student1))
print(student1 == student2)
print(student1 is student2)

student1 = student2
print("Class id - " , student1)
print("Class id - " , student2)
print(student1 == student2)
print(student1 is student2)

