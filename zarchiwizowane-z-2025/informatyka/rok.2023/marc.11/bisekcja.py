def f(x):
    return x+1

def bisekcja(a,b,n):
    for i in range(n):
        c = (a + b) / 2
        if f(c) == 0:
            return c
        if f(a) * f(c) < 0:
            b = c
        else:
            a = c
    return (a+b)/2