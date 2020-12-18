import os
import csv

video=input("What movie are you looking for?")

csvpath = os.path.join('..', 'Python Practice', 'netflix_ratings.csv')

print("Hello, Viewer")

with open(csvpath) as csvfile:

    # CSV reader specifies delimiter and variable that holds contents
    csvreader = csv.reader(csvfile, delimiter=',')

    print(csvreader)

    # Read the header row first (skip this step if there is row header)
    csv_header = next(csvreader)






