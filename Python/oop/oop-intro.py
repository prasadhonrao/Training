class Player:

    def __init__(self, name):
        self.name = name
        
    def say_hello(self):
        print("Hello, ", self.name)

    def score_runs(self, runs):
        print(self.name + " has just scored " + str(runs) + " runs" )

srt = Player("Sachin Tendulkar")
srt.say_hello()
srt.score_runs(100)

vk = Player("Virat Kohli")
vk.say_hello()
vk.score_runs(50)
