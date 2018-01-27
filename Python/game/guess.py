import random 

print("Hello, What is your favorite number?")
number = input()

print("Your favorite number is " + number)

#generate randon number between 1 to 100
minNumber = 1
maxNumber = 100
magicNumber = random.randint(minNumber, maxNumber)

print(magicNumber)

message = "The magic number is between {0} and {1}"
print(message.format(minNumber, maxNumber))

found = False
while not found:
    print("Guess what it is?")
    guess = int(input())
    if guess == magicNumber:
        found = True
    if guess < magicNumber:
        print("Too low")
    if guess > magicNumber:
        print("Too high")
print("You got it!")