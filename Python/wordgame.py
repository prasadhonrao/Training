import random

def get_random_word():
    print("Getting random word")
    words = ['pizza', 'cheese', 'oranges', 'banana']
    word = words[random.randint(0, len(words)-1)]
    return word

def show_word(word):
    for character in word:
        print(character, " ", end="")
    print("")

def get_guess():
    print("Enter a letter")
    return input()

def process_letter(letter, random_word, blanked_word):
    result = False

    for i in range(0,len(random_word)):
        if random_word[i] == letter:
            result = True
            blanked_word[i] = letter
    
    return result

def print_strikes(number_of_strikes):
    for i in range(0, number_of_strikes):
        print("X ", end="")
    print("")

def play_word_game():
    print("Playing")
    strikes = 0
    max_strikes = 3
    playing = True

    random_word = get_random_word()
    blanked_word = list("_" * len(random_word))

    while playing:
        show_word(blanked_word)
        letter = get_guess()
        found = process_letter(letter, random_word, blanked_word)
        
        if not found:
            strikes = strikes + 1
            print_strikes(strikes)

        if strikes >= max_strikes:
            playing = False

        if not "_" in blanked_word:
            playing = False

    if strikes >= max_strikes:
        print("Loser!")
    else:
        print("Winner!")

print("Game started")
play_word_game()
print("Game over")
