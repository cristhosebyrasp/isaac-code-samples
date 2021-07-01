file_data = open("shopping.txt", "a")
new_data = ["Cheese\n", "Tea\n", "Chocolate\n"]
file_data.writelines(new_data)
file_data.close()
