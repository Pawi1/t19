"""
Horner's Method
"""
"""
Zadanie 1
Napisz program w języku Python, który obliczy wartość wielomianu podanego przez użytkownika, wykorzystując algorytm
naiwny. Użytkownik podaje współczynniki wielomianu jako liczby rozdzielone spacjami, 
przy czym pierwsza liczba oznacza wyraz wolny a0, a ostatnia współczynnik przy najwyższej potędze.
"""
def polynomial(l:list[int], x:float)->float:
    n:int = len(l) - 1
    y:float = l[0]
    power:float = 1
    for i in range(1,n+1):
        power *= x
        y = y + l[i] * power
    return y
user_list:list[int] = list(map(int,input('Podaj współczynniki rozdzielone spacjami: ').split()))
user_x = float(input('Podaj x: '))
print(polynomial(user_list,user_x))
"""
Zadanie 2
Napisz program w języku Python, który obliczy wartość wielomianu podanego przez użytkownika, wykorzystując
schemat Hornera w wersji iteracyjnej (zgodnie z przykładem 2). Użytkownik podaje współczynniki wielomianu jako liczby
rozdzielone spacjami, przy czym pierwsza liczba oznacza wyraz wolny a0, a ostatnia współczynnik przy najwyższej potędze.
"""
def horner(l:list[int],x:float)->float:
    n:int = len(l) - 1
    y:float = l[n]
    for i in range(n-1,-1,-1):
        y *= x
        y += l[i]
    return y
user_list:list[int] = list(map(int,input('Podaj współczynniki rozdzielone spacjami: ').split()))
user_x = float(input('Podaj x: '))
print(horner(user_list,user_x))
"""
Zadanie 3
Napisz program w języku Python, który obliczy wartość wielomianu podanego przez użytkownika, wykorzystując schemat Hornera
w wersji rekurencyjnej. Użytkownik podaje współczynniki wielomianu jako liczby rozdzielone spacjami, przy czym pierwsza liczba
oznacza wyraz wolny a0, a ostatnia współczynnik przy najwyższej potędze.
"""
def horner_recursive(l:list[int],x:float,n:int = None)->float:
    if n is None:
        n = len(l) - 1
    if n == 0:
        return l[0]
    return l[n] + x * horner_recursive(l, x, n - 1)






