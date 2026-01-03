# Personal Project - Item Ranking Program
The Python file for the list sorter I made for ranking favorite items.
Created by Levi Zelley in February of 2022.

## File Use
Primarily this file is here for reference to my coding habits, but if you want to see the program run, you merely have to download the file and have Python installed.

## Writeup
**Goal:** Create a program that would allow many items in a list to be ranked against each other, taking as little time as possible.

**Features:** Class object for list items, containing lists of objects ranked above itself and objects ranked below. These lists are used to skip ranking in cases where one character is already logically above or below the other (A was ranked higher than C, B was ranked lower than C, A is obviously higher than B even without direct ranking). Program loops until all objects are logically ranked, at which point objects are ranked by the amount of objects ranked higher than them.

**End Result:** This program still takes longer than I would like it to, but it was an excellent exercise in class objects and how to cut down on the amount of times an item would be ranked. It performs its intended function perfectly.