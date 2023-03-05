# Два различных натуральных числа n и m называются дружественными,
# если сумма делителей числа n (включая 1, но исключая само n) равна числу m и наоборот.
# Например, 220 и 284 – дружественные числа.
# По данному числу k выведите все пары дружественных чисел,
# каждое из которых не превосходит k.
# Программа получает на вход одно натуральное число k, не превосходящее 105.
# Программа должна вывести все пары дружественных чисел, каждое из которых не превосходит k.
# Пары необходимо выводить по одной в строке, разделяя пробелами.
# Каждая пара должна быть выведена только один раз (перестановка чисел новую пару не дает).

def list_n(num):
    summa = 
    for i in range(1, num // 2 + 1):
        if num % i == 0:
            summa += i
    return summa


number = int(input('Введите число: '))
for i in range(1, number):
    div_i = list_n(i)
    for j in range(i + 1, number):
        div_j = list_n(j)
        if div_j == i and div_i == j and  i != j:
            print(i, j)


def div_list(number: int) -> dict:
    div_dict = {}
    for j in range(1, number):
        summa_div = 0
        for i in range(1, j):
            if j%i == 0:
                summa_div += i
        div_dict[j] = summa_div
    return div_dict

number = int(input('Введите предел: '))

div_dict = div_list(number)

for i in range(1,number):
    for j in range(i,number):
        if i == div_dict.get(j) and j == div_dict.get(i) and i != j:
            print(i, j)