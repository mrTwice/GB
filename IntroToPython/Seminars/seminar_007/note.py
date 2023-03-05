# dict compr.
print({i: i * i for i in range(1, 6)})

# set compr.
from random import randint as rd
print({rd(1, 10) for i in range(10)})