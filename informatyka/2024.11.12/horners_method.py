"""
Horner's Method
"""
"""
Zadanie 1
Napisz program w języku Python, który obliczy wartość wielomianu podanego przez użytkownika, wykorzystując algorytm
naiwny. Użytkownik podaje współczynniki wielomianu jako liczby rozdzielone spacjami, 
przy czym pierwsza liczba oznacza wyraz wolny a0, a ostatnia współczynnik przy najwyższej potędze.
"""
def polynomial(l:list[int])->int:
    n:int = len(l) - 1
    y:int = l[0]
    power:int = 1
    for i in range(1,n):
        power *= x
        y = y + l[i] * power
    return y
user_list:list[int] = list(map(int,input('Podaj współczynniki rozdzielone spacjami: ').split()))


