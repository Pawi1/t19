# """
# Horner's Method
# """
# """
# Zadanie 1
# Napisz program w języku Python, który obliczy wartość wielomianu podanego przez użytkownika, wykorzystując algorytm
# naiwny. Użytkownik podaje współczynniki wielomianu jako liczby rozdzielone spacjami,
# przy czym pierwsza liczba oznacza wyraz wolny a0, a ostatnia współczynnik przy najwyższej potędze.
# """
#
#
# def polynomial(l: list[int], x: float) -> float:
#     n: int = len(l) - 1
#     y: float = l[0]
#     power: float = 1
#     for i in range(1, n + 1):
#         power *= x
#         y = y + l[i] * power
#     return y
#
#
# user_list: list[int] = list(map(int, input('Podaj współczynniki rozdzielone spacjami: ').split()))
# user_x = float(input('Podaj x: '))
# print(polynomial(user_list, user_x))
# """
# Zadanie 2
# Napisz program w języku Python, który obliczy wartość wielomianu podanego przez użytkownika, wykorzystując
# schemat Hornera w wersji iteracyjnej (zgodnie z przykładem 2). Użytkownik podaje współczynniki wielomianu jako liczby
# rozdzielone spacjami, przy czym pierwsza liczba oznacza wyraz wolny a0, a ostatnia współczynnik przy najwyższej potędze.
# """
#
#
# def horner(l: list[int], x: float) -> float:
#     n: int = len(l) - 1
#     y: float = l[n]
#     for i in range(n - 1, -1, -1):
#         y *= x
#         y += l[i]
#     return y
#
#
# user_list: list[int] = list(map(int, input('Podaj współczynniki rozdzielone spacjami: ').split()))
# user_x = float(input('Podaj x: '))
# print(horner(user_list, user_x))
# """
# Zadanie 3
# Napisz program w języku Python, który obliczy wartość wielomianu podanego przez użytkownika, wykorzystując schemat Hornera
# w wersji rekurencyjnej. Użytkownik podaje współczynniki wielomianu jako liczby rozdzielone spacjami, przy czym pierwsza liczba
# oznacza` wyraz wolny a0, a ostatnia współczynnik przy najwyższej potędze.
# """
#
#
# def horner_recursive(l: list[int], x: float) -> float:
#     n = len(l) - 1
#     if n == 0:
#         return l[0]
#     return x * horner_recursive(l[1:], x) + l[0]
#
#
# user_list: list[int] = list(map(int, input('Podaj współczynniki rozdzielone spacjami: ').split()))
# user_x = float(input('Podaj x: '))
# print(horner_recursive(user_list, user_x))
# """
# Zadanie 5
# """
#
#
# def reverse_polynomial(l: list[int], x: float) -> float:
#     n: int = len(l) - 1
#     y: float = l[n]
#     power: float = 1
#     for i in range(n - 1, -1, -1):
#         power *= x
#         y = y + l[i] * power
#     return y
#
#
# user_list: list[int] = list(
#     map(int, input('Podaj współczynniki (w kolejności malejąco) rozdzielone spacjami: ').split()))
# user_x = float(input('Podaj x: '))
# print(reverse_polynomial(user_list, user_x))
# """
# """
#
#
# def reverse_horner(l: list[int], x: float) -> float:
#     n: int = len(l) - 1
#     y: float = l[0]
#     for i in range(1, n):
#         y *= x
#         y += l[i]
#     return y
#
#
# user_list: list[int] = list(
#     map(int, input('Podaj współczynniki (w kolejności malejąco) rozdzielone spacjami: ').split()))
# user_x = float(input('Podaj x: '))
# print(reverse_horner(user_list, user_x))
# """
# Zadanie 6
# Napisz program w języku Python, który zamieni liczbę binarną podaną przez użytkownika na system dziesiętny, wykorzystując schemat Hornera.
# """
# user_list: list[int] = list(
#     map(int, input('Podaj liczbę binarną: ').rstrip()))
# def bin_horner(l: list[int]) -> int:
#     n: int = len(l)-1
#     y: int = l[0]
#     for i in range(1,n+1):
#         y *= 2
#         y += l[i]
#     return y
# print(bin_horner(user_list))
# """
# Zadanie 7
# Napisz program w języku Python, który zamieni liczbę podaną przez użytkownika w systemie o podstawie p
# (p z przedziału od 2 do 9) na system dziesiętny, wykorzystując schemat Hornera.
# """
# user_list: list[int] = list(
#     map(int, input('Podaj liczbę w systemie p: ').rstrip()))
# user_p:int = int(input('Podaj p: '))
# def p_horner(l: list[int], p:int) -> int:
#     n: int = len(l)-1
#     y: int = l[0]
#     for i in range(1,n+1):
#         y *= p
#         y += l[i]
#     return y
# print(p_horner(user_list,user_p))
"""
Zadanie 8
Wielomianem parzystym nazywamy wielomian stopnia 2n postaci
R(x) = anx2n + an–1x2n – 2 + ... + a2x4 + a1x2 + a0,
tzn. taki, w którym występują tylko parzyste potęgi zmiennej x.

Bazując na schemacie Hornera, napisz algorytm o poniższej specyfikacji (w pseudokodzie lub wybranym języku programowania), który oblicza wartość parzystego wielomianu R(x).

Dane:
n — liczba całkowita, n ≥ 0,
x — liczba rzeczywista,
a0, a1, ..., an — liczby rzeczywiste.
Wynik: wartość R(x).

Przy ocenie rozwiązania będzie brana pod uwagę liczba operacji mnożenia i dodawania wykonywanych przez algorytm. 
"""
def even_horner(l: list[float], x: float) -> float:
    n: int = len(l) - 1
    y: float = l[n]
    power_x: float = x*x
    for i in range(n - 1, -1, -1):
        y *= power_x
        y += l[i]
    return y
user_list: list[int] = list(map(int, input('Podaj współczynniki rozdzielone spacjami: ').split()))
user_x = float(input('Podaj x: '))
print(even_horner(user_list,user_x))