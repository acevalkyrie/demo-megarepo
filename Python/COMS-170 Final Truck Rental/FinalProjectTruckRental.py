#### Mary Sordyl
#### Final Project
#### COMS-170-HYB03: Fall 2021
#### Due: 12/21/21
#### Final Project - Truck Rental
#============================================================
# Variable          Type        Purpose
#============================================================
#

global ALLOWEDMILES
ALLOWEDMILES = 175

def main():
    ClassA = [[15.99, 109.99], 0.44]
    ClassB = [[25.99, 179.99], 0.64]
    ClassC = [[35.99, 239.99], 0.74]
    strSelect = ""
    while strSelect != "x":
        print("""
============================================================================
                  STARSTRUCK RENTALS
    ----    ----    ----    ----    ----    ----    ----    ----    ----
                          More Bang For Your Truck
============================================================================

RENTAL PRICE ESTIMATOR:
        Truck Classification  Daily Cost  Weekly Cost  Mileage Cost*
    A.           A              $""", ClassA[0][0], """      $""", ClassA[0][1], """    $""", ClassA[1], """ per mile
    B.           B              $""", ClassB[0][0], """      $""", ClassB[0][1], """    $""", ClassB[1], """ per mile
    C.           C              $""", ClassC[0][0], """      $""", ClassC[0][1], """    $""", ClassC[1], """ per mile
    X.  EXIT
                  *weekly mileage only applies after 1st """, ALLOWEDMILES, """ miles per week.
""", sep="")
        strSelect = input("Select the truck classification you will be renting: ").lower()
        if strSelect != "x":
            strDayWeek = input("Will you be renting (D)aily or (W)eekly? ").lower()
            intMiles = int(input("How many miles will you be driving in total? "))
            if strSelect == "a":
                if strDayWeek == "d":
                    intDays = int(input("For how many days will you be renting? "))
                    intTotalCost = DailyCostCalc(intDays, ClassA[0][0], intMiles, ClassA[1])
                elif strDayWeek == "w":
                    intWeeks = int(input("For how many weeks will you be renting? "))
                    intTotalCost = WeeklyCostCalc(intWeeks, ClassA[0][1], intMiles, ClassA[1])
            elif strSelect == "b":
                if strDayWeek == "d":
                    intDays = int(input("For how many days will you be renting? "))
                    intTotalCost = DailyCostCalc(intDays, ClassB[0][0], intMiles, ClassB[1])
                elif strDayWeek == "w":
                    intWeeks = int(input("For how many weeks will you be renting? "))
                    intTotalCost = WeeklyCostCalc(intWeeks, ClassB[0][1], intMiles, ClassB[1])
            elif strSelect == "c":
                if strDayWeek == "d":
                    intDays = int(input("For how many days will you be renting? "))
                    intTotalCost = DailyCostCalc(intDays, ClassC[0][0], intMiles, ClassC[1])
                elif strDayWeek == "w":
                    intWeeks = int(input("For how many weeks will you be renting? "))
                    intTotalCost = WeeklyCostCalc(intWeeks, ClassC[0][1], intMiles, ClassC[1])
            print("""
YOUR TOTAL ESTIMATED COST: $""", format(intTotalCost, ".2f"), sep="")
            input("Press enter to continue.")
        else:
            input("Thanks for using StarsTruck Rentals! (press enter to finish)")

def DailyCostCalc(Days, DailyRate, Miles, MileageRate):
    DailyCost = (Days * DailyRate) + (Miles * MileageRate)
    return DailyCost

def WeeklyCostCalc(Weeks, WeeklyRate, Miles, MileageRate):
    WeeklyCost = (Weeks * WeeklyRate) + ((Miles - (ALLOWEDMILES * Weeks)) * MileageRate)
    return WeeklyCost

main()
