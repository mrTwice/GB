# Задача No9. Общее обсуждение
# По данному целому неотрицательному n вычислите значение n!. N! = 1 * 2 * 3 * ... * N (произведение всех чисел от 1 до N) 0! = 1
# Решить задачу используя цикл while
# Input: 5
# Output: 120

number = int(input('Введите число: '))

# m = 1
# for i in range(1,number+1):
#     m = m * i 
# print(m)

m = 1
i = 1
while i < number + 1:
    m = m * i
    i +=1
print(m)



