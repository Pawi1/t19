"""
Nazwa: nwd
Opis funkcji: Funkcja zwraca największy wspólny dzielnik dwóch liczb
Parametry:  a - pierwsza liczba
            b - druga liczba
Zwacany typ i opis: Funcja zwraca liczbę całkowitą
Autor: Paweł Rutkowski
"""


def nwd(a: int, b: int) -> int:
    while a != b:
        if a > b:
            a -= b
        else:
            b -= a
    return a
