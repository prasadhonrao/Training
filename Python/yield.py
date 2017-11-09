def generate_inputs():
    numbers = list(range(5))
    for i in numbers:
        print("value : " + str(i))
        yield i * i

my_generator = generate_inputs() 

for i in my_generator:
    print(i)