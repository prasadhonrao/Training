import os

def get_files(dir):
    file_list = os.listdir(dir)
    print(file_list)

get_files(r"D:\Git\Training\Python")