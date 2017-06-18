students = []

class Student:
    #static variable
    school_name = "Kennedy Park International"

    #constructor
    def __init__(self, name, id=0):
        self.name = name
        self.id = id
        students.append(self)

    #override toString
    def __str__(self):
        return "Student " + self.name.capitalize()

    def get_school_name(self):
        return self.school_name

# Parent class is enclosed in parantheses
class HighSchoolStudents(Student):
    school_name = "Kennedy Park HighSchool"

    # overridden method
    def get_school_name(self):
        return self.name + " is a high school student"


mark = HighSchoolStudents("mark")
print(mark.get_school_name())
print(HighSchoolStudents.school_name)