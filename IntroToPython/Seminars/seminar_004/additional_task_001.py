# Проблема заключается в том, что, когда мы с Вами уберем подряд идущие элементы могут еще появиться
# Пример:
# 5 1 1 3 3 3 1 1 2
# 1-ый раз: 5 1 1 1 1 2
# 2-ой раз: 5 2
# Ответ: 7


# Написать программу, которая определяет сколько шариков будет уничтожено. 
# Естественно цепочек из трех и более шариков одного цвета, в начальный момент может быть не более одной.
# Ввводится количествл щариков не более 1000, цвета шариков от 0 до 9


bolls = [5, 1, 1, 3, 3, 3, 1, 1, 2]
colors = set(bolls)
dictionary = {}

for i in range(0, len(bolls)):
    max = 0
    if bolls[i] == bolls[i - 1]:
        max += 1

