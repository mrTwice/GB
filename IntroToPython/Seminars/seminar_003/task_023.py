# Задача №23. Решение в группах
# Дан массив, состоящий из целых чисел. Напишите 
# программу, которая подсчитает количество 
# элементов массива, больших предыдущего (элемента 
# с предыдущим номером) 
# Input: [0, -1, 5, 2, 3]
# Output: 2 (-1 < 5, 2 < 3)
# Примечание: Пользователь может вводить значения 
# списка или список задан изначально.

list_of_numbers = [0, -1, 5, 2, 3]
count = 0
for i in range(1, len(list_of_numbers)):
    if int(list_of_numbers[i]) > int( list_of_numbers[i -1]):
        count += 1
print(f'Количество элементов удовлетворяющих условию: {count}')
    