list_of_numbers = [1, 2, 3, 4, 5]
print(list_of_numbers)
k = 3
for i in range(0, k):
    list_of_numbers.insert(0, list_of_numbers.pop())
print(list_of_numbers) 
