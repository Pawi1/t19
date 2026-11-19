a:int = int(input("Podaj a: "))
b:int = int(input("Podaj b: "))
"""
*****************************************************
nazwa funkcji:        nwd
opis funkcji:         Zwraca najmniejszy wspólny dzielnik dwóch liczb
parametry:            a - liczba całkowita: pierwsza liczba
                      b  - liczba całkowita: druga liczba
zwracany typ i opis:  liczba całkowita, zwraca liczbe odpowiadającą nwd liczby a i b
autor:                0000000000000
*****************************************************
"""
def nwd(a:int, b:int) -> int:
    while a != b:
        if a < b:
            b -= a
        else:
            a -= b
    return a
print(nwd(a,b))