file_data = open("notes.txt", "w")
new_data = input("Request user's input here: ")
file_data.write(new_data)
file_data.close()
