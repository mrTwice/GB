# Задана последовательность натуральных чисел, завершающаяся числом 0. Требуется определить значение второго по величине элемента в этой последовательности, то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.
# Входной файл INPUT.TXT содержит последовательность неотрицательных целых чисел, не превышающих значения 100. Гарантируется, что во входных данных не более 100 чисел и среди них есть хотя бы одно число 0, перед которым идет как минимум 2 элемента.
# В выходной файл OUTPUT.TXT выведите целое число – значение второго максимума.

numbers = [1, 17, 6, 4, 3, 9, 8, 19, 0, 20 , 10]
print(numbers)

i = 2
max1 = numbers[0]
max2 = numbers[1]
if max1 < max2:
        temp = max1
        max1 = max2
        max2 = temp
while numbers[i] != 0:
        if numbers[i] > max1:
                max2 = max1
                max1 = numbers[i]
        i += 1
print(max1, max2)



# попробовать решить через while