my_file = open('binfile.bin','wb')
numberList = [5, 10, 15, 20, 25]
array = bytearray(numberList)
my_file.write(array)
my_file.close()
