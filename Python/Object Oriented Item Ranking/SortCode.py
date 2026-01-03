import random # import random for use in shuffling lists

####################################
######## INITIATE CHOICE CLASS
#### entire program is dependeng on choice class and its methods
########################

class Choice:
    # attributes initialized for every instance of Choice include name, associated color, associated image, rank, and lists for 
    def __init__(self, name, color, image):
        self.name = name # required when called
        self.color = color # required when called
        self.image = image # required when called
        self.rank = 1 # initialized by default

        # rankedLower and rankedHigher lists enable avoiding redundant comparisons
        self.rankedLower = [] # initialized by default
        self.rankedHigher = [] # initialized by default

    ########################
    #### SET METHODS
    
    def change_rank(self, rank): # method to easily adjust rank for later sorting
        self.rank = rank

    def add_lower(self, lower):
        self.rankedLower.append(lower) # append an object that is ranked lower

    def add_higher(self, higher):
        self.rankedHigher.append(higher) # append an object that is ranked higher

    def ranked_lower(self, lower): # method to avoid unnecessary comparisons and shorten sorting process
        # if function is called, input has been determined to rank lower than self
        
        # add the lower ranked item into self's rankedLower list
        self.add_lower(lower)
    
        for i in self.rankedHigher: # if lower is ranked LOWER than self, it must also be LOWER than anything ranked HIGHER than self
            if i not in lower.rankedHigher: # for each item ranked HIGHER than self, see if lower isn't already ranked LOWER than them
                i.add_lower(lower) # add lower to the item's rankedLower list
                lower.add_higher(i) # add the item to lower's rankedHigher list

        # add self to the lower ranked item's rankedHigher list
        lower.add_higher(self)
        
        for i in lower.rankedLower: # if self is ranked HIGHER than lower, it must also be HIGHER than anything ranked LOWER than self
            if i not in self.rankedLower: # for each item ranked LOWER than lower, see if self isn't already ranked HIGHER than them
                self.add_lower(i) # add the item to self's rankedLower list
                i.add_higher(self) # add self to the item's rankedHigher list

####################################
######## DEFINE MAIN FUNCTION
#### the base of the program and all major function calls all take place here
########################

def main():

    # create objects for each choice to be ranked
    apple = Choice("Apple", "#f03223", "https://picsum.photos/120")
    pear = Choice("Pear", "#c5db34", "https://picsum.photos/120")
    peach = Choice("Peach", "#e7905b", "https://picsum.photos/120")
    plum = Choice("Plum", "#51056c", "https://picsum.photos/120")
    apricot = Choice("Apricot", "#e7a156", "https://picsum.photos/120")
    cantaloupe = Choice("Cantaloupe", "#e09442", "https://picsum.photos/120")
    honeydew = Choice("Honeydew", "#70e96b", "https://picsum.photos/120")
    watermelon = Choice("Watermelon", "#ea5a63", "https://picsum.photos/120")
    cherry = Choice("Cherry", "#dc0909", "https://picsum.photos/120")
    strawberry = Choice("Strawberry", "#e73c47", "https://picsum.photos/120")
    raspberry = Choice("Raspberry", "#e21b28", "https://picsum.photos/120")
    blackberry = Choice("Blackberry", "#11042b", "https://picsum.photos/120")
    blueberry = Choice("Blueberry", "#860ca0", "https://picsum.photos/120")
    grape = Choice("Grape", "#482294", "https://picsum.photos/120")
    kiwi = Choice("Kiwi", "#57c325", "https://picsum.photos/120")
    pineapple = Choice("Pineapple", "#e2db41", "https://picsum.photos/120")
    starfruit = Choice("Starfruit", "#d5e241", "https://picsum.photos/120")
    dragonfruit = Choice("Dragonfruit", "#d51e41", "https://picsum.photos/120")
    pomegranate = Choice("Pomegranate", "#7a1224", "https://picsum.photos/120")
    banana = Choice("Banana", "#f6ea77", "https://picsum.photos/120")
    mango = Choice("Mango", "#edbb1a", "https://picsum.photos/120")
    orange = Choice("Orange", "#f09c06", "https://picsum.photos/120")
    lemon = Choice("Lemon", "#e9f623", "https://picsum.photos/120")
    lime = Choice("Lime", "#5ac70b", "https://picsum.photos/120")
    #### TEMPLATE :
    #### variable = Choice("name", "#hex", "imageurl")

    # initialize required variable to start menu loop
    strContinue = "yes"
    while strContinue.lower() != "no":
        # add all choice objects to choiceList and initialize the currentChoices list
        choiceList = [apple, pear, peach, plum, apricot, cantaloupe, honeydew, watermelon, cherry, strawberry, raspberry, blackberry, blueberry, grape, kiwi, pineapple, starfruit, dragonfruit, pomegranate, banana, mango, orange, lemon, lime]
        currentTwo = []
        
        # shuffle the order of the list using imported random module
        random.shuffle(choiceList)

        # move the first two items from the full choices list to the current choices list
        for i in range(2):
            currentTwo.append(choiceList[0])
            del choiceList[0]

        ####################################
        ######## BEGIN LOOP
        #### loop will count the amount of questions asked to sort items, and perform initial sorting
        #### initial sorting will always favor the preferred item; keeping it as an option and only swapping out the lower ranked item
        ########################

        questionCount = 0 # initialize a count so we know how many questions it takes to sort the choices
        # loop until any item reaches lowest rank (two choices have been removed from choiceList, go until lowest ranked item has every other item ranked higher; equal to choiceList + 1)
        while len(currentTwo[0].rankedHigher) < (len(choiceList) + 1) and len(currentTwo[1].rankedHigher) < (len(choiceList) + 1):
            skipToShuffle = False # allows us to easily shortcut to shuffling when necessary

            # check to make sure the two items being ranked haven't already logically been ranked
            skipToShuffle = checkIfSkippable(currentTwo)

            if not skipToShuffle:
                questionCount += 1 # increment counter to see how many questions we've asked the user

                # store user's choice between the two options in currentTwo (or the choice to reshuffle)
                userChoice = input(str(questionCount) + ": Enter A if you prefer " + str(currentTwo[0].name) + ", B if you prefer " + str(currentTwo[1].name) + ", or C for a random pair.\n")

                # use userRanking function to adjust rankings and swap out the lower ranked item as needed
                choiceList, currentTwo, skipToShuffle = userRanking(choiceList, currentTwo, userChoice)
                # ^ returns the modified choiceList, currentTwo, and the condition to decide if the list should be shuffled

            if skipToShuffle: # if items already ranked or user chose to shuffle, call shuffleList to put the current choices back and reshuffle
                choiceList, currentTwo = shuffleList(choiceList, currentTwo)
                # ^ returns the shuffled list and the next two choices
                # shuffling instead of swapping out the lower ranked item increases chance of all items being ranked against each other

        # once loop is broken, move the final choices back into the full list so all ranked items are present
        choiceList.append(currentTwo[0])
        choiceList.append(currentTwo[1])

        ########################
        #### increase the specifics of the list by sorting more comprehensively now using finalRankCheck function
        choiceList = finalRankCheck(choiceList, questionCount)

        determineRank(choiceList) # use determineRank function to give each item a number rank

        choiceList = sortFinalList(choiceList) # use sortFinalList function to order the list from 1st rank to final rank

        # print out the sorted and ranked items by rank
        for i in choiceList:
            print(i.rank, ": ", i.name, sep="")

        # get user's choice to re-sort or end program
        strContinue = input("\nWould you like to continue? Yes or no?\n")

        # if they choose to repeat, reset all choices back to their initial states
        if strContinue.lower() != "no":
            for i in choiceList:
                i.change_rank(1)
                i.rankedLower.clear()
                i.rankedHigher.clear()



########################
#### DEFINE CHECKIFSKIPPABLE FUNCTION
def checkIfSkippable(cisCurrent):
    # check to make sure the two items being ranked haven't already been ranked against each other
    if cisCurrent[0] in cisCurrent[1].rankedLower or cisCurrent[0] in cisCurrent[1].rankedHigher:
        return True # if they have been ranked before, return that the options should be reshuffled

    return False # otherwise, return that we can proceed to the ranking



####################################
######## DEFINE USERRANKING FUNCTION
#### from the user's input, determine which item's ranked_lower method to call, or shuffle the answers
########################

def userRanking(urChoices, urCurrent, urUserChoice):

    # user prefers the first option
    if urUserChoice.lower() == "a":
        # call first option's ranked_lower method to rank option two as lower
        urCurrent[0].ranked_lower(urCurrent[1])

        # switch the lower ranked item out for the next item in the full list
        urChoices.append(urCurrent[1])
        urCurrent[1] = urChoices[0]
        del urChoices[0]

    # user prefers the second option
    elif urUserChoice.lower() == "b":
        # call second option's ranked_lower method to rank option 1 as lower
        urCurrent[1].ranked_lower(urCurrent[0])

        #switch the lower ranked item out for the next item in the list
        urChoices.append(urCurrent[0])
        urCurrent[0] = urChoices[0]
        del urChoices[0]

    # user chose to reshuffle rather than choose
    elif urUserChoice.lower() == "c":
        return urChoices, urCurrent, True # return unmodified lists and that the lists need to be reshuffled

    return urChoices, urCurrent, False # return modified lists (or unmodified in event of incorrect input) and that the list does not need to be reshuffled



########################
#### DEFINE SHUFFLELIST FUNCTION
def shuffleList(slChoices, slCurrent):
    for i in range(2): # move the current unshuffled choices back into the full list
        slChoices.append(slCurrent[0])
        del slCurrent[0]
        
    random.shuffle(slChoices) # shuffle

    for i in range(2): # move the two new options from the full list into the current choices list
        slCurrent.append(slChoices[0]) 
        del slChoices[0]

    return slChoices, slCurrent # return shuffled lists



####################################
######## DEFINE FINALRANKCHECK FUNCTION
#### use the more thorough method to make sure any stragglers that haven't been ranked against each other are now ranked
########################

def finalRankCheck(frcChoices, frcCount):
    # loop every item in the list
    for i in frcChoices: 
        # use a range to get the index of every item on the list
        for j in range(len(frcChoices)):

            # as long as it's not the same item, make sure all items have been ranked against each other
            if frcChoices[j] != i and frcChoices[j] not in i.rankedHigher and frcChoices[j] not in i.rankedLower:
                
                frcCount += 1 # increment counter to see how many questions we've asked the user
                userChoice = input(str(frcCount) + ": Enter A if you prefer " + str(i.name) + ", B if you prefer " + str(frcChoices[j].name) + ", or C for a random pair.\n")
                
                # user prefers the first option
                if userChoice.lower() == "a":
                    # call first option's ranked_lower method to rank option two as lower
                    i.ranked_lower(frcChoices[j])

                # user prefers the second option
                elif userChoice.lower() == "b":
                    # call second option's ranked_lower method to rank option 1 as lower
                    frcChoices[j].ranked_lower(i)

                # user chose to reshuffle rather than choose
                else:
                    random.shuffle(frcChoices) #shuffle
                    frcChoices = finalRankCheck(frcChoices, frcCount) #call the function again to restart from the beginning of the shuffled list
                    return frcChoices # once any recursive version of finalRankCheck finishes to completion (no matter how many levels deep it goes) end them all here rather than running through all their calculations
                    
    return frcChoices # return the list



########################
#### DEFINE DETERMINERANK FUNCTION
def determineRank(drChoices):
    # loop through each choice and set the rank based on how many items are ranked abve
    for i in drChoices:
        i.change_rank(1 + len(i.rankedHigher)) # rank is 1 + however many items rank higher
        # number 1 would be the item that is 1 + 0 higher ranked items



########################
#### DEFINE DETERMINERANK FUNCTION
def sortFinalList(sflChoices):
    # sort list by rank
    try: # older versions of python can't use operator, so run a try catch
        import operator
    except ImportError:
        sortKey = lambda i: i.rank # use a lambda function to sort by attribute (in this case rank) if import fails
    else:
        sortKey = operator.attrgetter("rank") # operator is faster than lambda, so use it instead if possible

    sflChoices.sort(key = sortKey) # sortKey will sort the list by rank either way

    return sflChoices # return list with new ranked order



#### call main to begin program
main()
