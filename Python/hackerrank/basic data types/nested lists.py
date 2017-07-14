if __name__ == '__main__':

    scorecard = []

    for _ in range(int(input())):
        scorecard.append([input(), float(input())])
    
    # print(sorted(scorecard))

    second_highest = sorted(list(set([marks for name, marks in scorecard])))[1]

    # print(second_highest)

    print('\n'.join([a for a,b in sorted(scorecard) if b == second_highest]))
