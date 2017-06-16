students = []
class Student:
    def add_student(self, name, student_id = 100):
        student = {"name": name, "student_id" : student_id }
        students.append(student)

student = Student()
student.add_student("Prasad")
student.add_student("Jack", 200)

print(students)