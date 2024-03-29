# Последовательностью Фибоначчи называется последовательность чисел a0, a1, ..., an, ..., где
# a0 = 0, a1 = 1, ak = ak-1 + ak-2 (k > 1).
# Требуется найти N-е число Фибоначчи
# Input: 7
# Output: 21

# Задание необходимо решать через рекурсию
def f(n):
    if n == 0 or n == 1:
        return n
    return f(n - 1) + f(n - 2)

print(f(int(input())))