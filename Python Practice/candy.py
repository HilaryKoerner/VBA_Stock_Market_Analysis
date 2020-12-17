candy_list = ["Snickers", "Kit Kat", "Sour Patch Kids", "Juicy Fruit", "Swedish Fish", "Skittles", "Hershey Bar", "Starbursts", "M&Ms"]
for candy in candy_list:
    print(candy)

allowance = 5

candy_cart = []

for candy in candy_list:
    print(f"[{candy_list.index(candy)}]{candy}")


print("which candy would you like to bring home?")
for x in range(allowance):
    selected=input("Input the number of candy you want:")

    candy_cart.append(candy_list[int(selected)])

print("i brought home with me...")
for candy in candy_cart:
    print(candy)







# # The list of candies to print to the screen
# candy_list = ["Snickers", "Kit Kat", "Sour Patch Kids", "Juicy Fruit", "Swedish Fish", "Skittles", "Hershey Bar", "Starbursts", "M&Ms"]

# # The amount of candy the user will be allowed to choose
# allowance = 5

# # The list used to store all of the candies selected inside of
# candy_cart = []

# # Print out options







# # A For loop moves through a given range of numbers
# # If only one number is provided it will loop from 0 to that number
# for x in range(10):
#     print(x)

# # If two numbers are provided then a For loop will loop from the first number up until it reaches the second number
# for x in range(20, 30):
#     print(x)

# # If a list is provided, then the For loop will loop through each element within the list
# words = ["Peanut", "Butter", "Jelly", "Time", "Is", "Now"]
# for word in words:
#     print(word)

# # A While Loop will continue to loop through the code contained within it until some condition is met
# x = "Yes"
# while x == "Yes":
#     print("Whee! Merry-Go-Rounds are great!")
#     x = input("Would you like to go on the Merry-Go-Round again? ")
