students = []

def get_student_titlecase():
    students_titlecase = []
    for student in students:
        students_titlecase.append(student["name"].title())
    return students_titlecase

def print_student_titlecase():
    student_titlecase = get_student_titlecase()
    print(student_titlecase)

def add_student(name, student_id = 100):
    student = {"name": name, "student_id": student_id}
    students.append(student)
    print("Student count is {0}".format(len(students)))

# **kwargs is used to pass variable number of arguments during function call
# def var_args(name, **kwargs):
#     print(name)
#     print(kwargs["description"], kwargs["feedback"])

# var_args(name = "Prasad Honrao", description = "37 yr old man", feedback="Python professional", random = None)

def save_file(student):
    try:
        f = open("students.txt", "a")
        f.write(student + "\n")
        f.close()
    except Exception:
        print("Could not save")

def read_file():
    try:
        f = open("students.txt", "r")
        for student in f.readlines():
            add_student(student)
        f.close()
    except Exception:
        print("Could not read")

# ADD NEW STUDENT BLOCK
# student_list = get_student_titlecase()
# add_student("Prasad Honrao", "101")

# ADD NEW STUDENT VIA USER INPUT AND DISPLAY THE LIST
# student_name = input("enter student name : ")
# student_id = input("enter student id : ")
# add_student(student_name, student_id)
# print_student_titlecase()

# USE BELOW CODE BLOCK IF YOU WANT TO ADD NEW STUDENT IN A LOOP
# add_new_student_flag = ''
# message = "Do you want to add new student record?? Press [Y] / [y] to continue. "
# add_new_student_flag = input(message)

# while (add_new_student_flag == 'Y' or add_new_student_flag == 'y'):
#     student_name = input("enter student name : ")
#     student_id = input("enter student id : ")
#     add_student(student_name, student_id)
#     add_new_student_flag = input(message)

# print_student_titlecase()

# READ FROM File
read_file()
print_student_titlecase()
student_name = input("enter student name : ")
student_id = input("enter student id : ")
add_student(student_name, student_id)
save_file(student_name)