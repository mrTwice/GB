# Задача №17. Общее обсуждение
# Дан список чисел. Определите, сколько в нем 
# встречается различных чисел.
# Input: [1, 1, 2, 0, -1, 3, 4, 4]
# Output: 6
# Примечание: Пользователь может вводить значения 
# списка или список задан изначально.


list_of_numbers = [1, 1, 2, 0, -1, 3, 4, 4]

# Конвертация списка во множество
set_of_numbers = set(list_of_numbers)
print(f'Уникальных элемнтов: {len(set_of_numbers)}')

# Наполнение множества через цикл for
for i in list_of_numbers:
    set_of_numbers.add(i)
print(f'Уникальных элемнтов: {len(set_of_numbers)}')

# Подсчет уникальных элементов без преобразования структуры
elements_in_list = len(list_of_numbers)
i = 0
while i < len(list_of_numbers):
    j =i + 1
    while j < len(list_of_numbers):
        if list_of_numbers[i] == list_of_numbers[j]:
            elements_in_list =elements_in_list - 1
        j += 1
    i +=1
print(f'Уникальных элемнтов: {elements_in_list}')
    
    
    
