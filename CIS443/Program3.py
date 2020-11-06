# CIS 443-01
#Program 3
#11-2-2020
# D8801
#Program shows percentage for each roll of games for Craps that will win or lose

"""Simulating the dice game Craps."""
import random
i = 0
w = 0
l = 0
total2 = 0
wins = {}
loses = {}
games = int(input("Enter games to be played: "))
while i < games:
    i += 1
    def roll_dice():
        """Roll two dice and return their face values as a tuple."""
        die1 = random.randrange(1, 7)
        die2 = random.randrange(1, 7)
        return (die1, die2)  # pack die face values into a tuple
    
    def display_dice(dice):
        """Display one roll of the two dice."""
        die1, die2 = dice  # unpack the tuple into variables die1 and die2
        #print(f'Player rolled {die1} + {die2} = {sum(dice)}')
    
    die_values = roll_dice()  # first roll
    display_dice(die_values)
    
    # determine game status and point, based on first roll
    sum_of_dice = sum(die_values)
    c = 1 
    if sum_of_dice in (7, 11):  # win
        game_status = 'WON'
        w += 1
        wins[w] = c
    elif sum_of_dice in (2, 3, 12):  # lose
        game_status = 'LOST'
        l += 1
        loses[l] = c
    else:  # remember point
        game_status = 'CONTINUE'
        my_point = sum_of_dice
#       print('Point is', my_point)
    
    # continue rolling until player wins or loses
    while game_status == 'CONTINUE':
        die_values = roll_dice()
        c += 1
        display_dice(die_values)
        sum_of_dice = sum(die_values)
    
        if sum_of_dice == my_point:  # win by making point
            game_status = 'WON'
            w += 1
            wins[w] = c
        elif sum_of_dice == 7:  # lose by rolling 7
            game_status = 'LOST'
            l += 1
            loses[l] = c
    # display "wins" or "loses" message
#    if game_status == 'WON':
#       print('Player wins', wins)            
#       else:
#       print('Player loses', loses)
flip = {} 
kvl = {}
def_val = 0

for key, value in wins.items(): 
    if value not in flip: 
        flip[value] = [key] 
    else: 
        flip[value].append(key) 

length_wins = {key: len(value) for key, value in flip.items()}
#print(length_wins)

#print('flipped win', flip)
#print('new', length_wins)
total = 0
     
flip2 = {} 
  
for key, value in loses.items(): 
    if value not in flip2: 
        flip2[value] = [key] 
    else: 
        flip2[value].append(key) 
        
length_loses = {key: len(value) for key, value in flip2.items()}
#print(length_loses)

for key in length_loses:
    if key in length_wins:
        #do nothing 
        none = 0
    else:
        length_wins[key] = 0

for key in length_wins:
    if key in length_loses:
        #do nothing 
        none = 0
    else:
        length_loses[key] = 1
wins_len = len(wins)
losses_len = len(loses)

total_len = wins_len + losses_len
wins_final = wins_len / total_len

losses_final = losses_len / total_len
        
divide = {key: length_wins[key] + length_loses[key]for key in length_wins.keys() & length_loses}
divide_total = sum(divide.values())
#print (divide)
print("\nPercentage of wins: ", "{0:.1f}%".format(wins_final* 100))
print("Percentage of losses: ", "{0:.1f}%".format(losses_final* 100))
print("Percentage of wins/losses based on total number of rolls")
print ('\nRolls     Resolved %       Cumulative %')
print ('          on this roll     of games resolved')
for key, value in divide.items():
    total = value/divide_total
    total *= 100
    total2 += total
    print (f'{key}         {(total):5f} %         {(total2):5f} % ')

#print('flipped loses', flip2)
#print('new 2',length_loses)


#resolved = Rolls won / rolls lost (for each role)


