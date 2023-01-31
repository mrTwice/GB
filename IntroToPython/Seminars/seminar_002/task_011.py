# Дано натуральное число A > 1. Определите, каким по счету числом Фибоначчи оно является, то есть выведите такое число n, что φ(n)=A.
# Если А не является числом Фибоначчи, выведите число -1.
# Input: 5 Output: 6

a = int(input('Введите натуральноет число A: '))
fib = 0
previous = 0
next = 1
count = 3
while fib < a:
    fib = previous + next
    if fib == a:print(f' Введенное число в ряде Фибоначи стоит под номером {count}')
    previous = next
    next = fib
    count +=1
if fib > a: print(-1)
