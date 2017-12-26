print("""\
#####   Fibonacci series  #####\n
# the sum of two elements defines the\n#   next element\n""")

a, b = 0, 1
while b < 20000:
    print(a, end=' ')
    a, b = b, a+b


print('\n')
