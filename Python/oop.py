class Person:

    def __init__(self, name):
        self.name = name
        
    def say_hello(self):
        print("Hello, ", self.name)

p1 = Person("Prasad")
p1.say_hello()

p2 = Person("Scott")
p2.say_hello()
