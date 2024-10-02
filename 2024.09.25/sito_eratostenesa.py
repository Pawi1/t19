"""Sito Eratostenesa"""

"""
Przykład 1.
Napisz algorytm w postaci pseudokodu, który wyświetli wszystkie liczby pierwsze mniejsze lub równe  n, gdzie n jest liczbą naturalną większą od 1, wykorzystując algorytm sita Eratostenesa.
Dane:
n - liczba całkowita większa od 1
Wyniki:
liczby pierwsze mniejsze lub równe n
Algorytm (sito Eratostenesa):
czy_pierwsza[0] ← fałsz
czy_pierwsza[1] ← fałsz
dla i=2,3,...,n wykonuj
  czy_pierwsza[i] ← prawda
p ← 2
dopóki p * p ⩽ n wykonuj
  jeżeli czy_pierwsza[p]=prawda
    dla i=p*p, p*(p+1),...,n wykonuj:
      czy_pierwsza[i] ← fałsz
  p ← p + 1
dla i=2,3,...,n wykonuj
  jeżeli czy_pierwsza[i]=prawda to
    wypisz i
"""
# n = int(input('Przyklad 1: Podaj n: '))
# def sito_eratostenesa(n):
#    czy_pierwsza = [True]*n
#    czy_pierwsza[0] = False
#    czy_pierwsza[1] = False
#    p = 2
#    while p * p <= n:
#        if czy_pierwsza[p] == True:
#            for i in range(p*p,n+1,p):
#                czy_pierwsza[i] = False
#        p += 1
#    for i in range(2,n+1):
#        if czy_pierwsza[i]:
#            print(i, end=' ')
"""
Przykład 2
Napisz program, który wczyta liczby z pliku liczby.txt do listy o
nazwie liczby i wyświetli długość tej listy oraz pierwsze 10 liczb z tej listy.
"""
plik = open("liczby.txt", "r")
liczby = list(map(int, plik.read().split()))
plik.close()
print(len(liczby))
print(liczby[:10])
"""
Zadanie 1.
Napisz program w języku Python, który wyświetli wszystkie liczby pierwsze mniejsze lub równe n, gdzie n
jest liczbą naturalną większą od 1, wykorzystując algorytm sita Eratostenesa.
"""


def sito_eratostenesa(n):
    czy_pierwsza = [True] * n
    czy_pierwsza[0] = False
    czy_pierwsza[1] = False
    p = 2
    while p * p <= n:
        if czy_pierwsza[p]:
            for i in range(p * p, n + 1, p):
                czy_pierwsza[i] = False
        p += 1
    for i in range(2, n + 1):
        if czy_pierwsza[i]:
            print(i, end=" ")


n = int(input("1: Podaj n: "))
sito_eratostenesa(n)

"""
Zadanie 2.
Napisz program w języku Python, który wyświetli liczbę oraz sumę liczb
pierwszych mniejszych lub równych n, gdzie n jest liczbą naturalną większą od 1,
wykorzystując algorytm sita Eratostenesa.
"""


def sito_eratostenesa_z_suma(n):
    czy_pierwsza = [True] * n
    czy_pierwsza[0] = False
    czy_pierwsza[1] = False
    p = 2
    while p * p <= n:
        if czy_pierwsza[p]:
            for i in range(p * p, n + 1, p):
                czy_pierwsza[i] = False
        p += 1
    suma = 0
    for i in range(2, n + 1):
        if czy_pierwsza[i]:
            suma += i
    print(n, "\n", suma)


n = int(input("1: Podaj n: "))
sito_eratostenesa_z_suma(n)
"""
Zadanie 3.
Zmodyfikuj pseudokod z przykładu 1 zamieniając pętlę dla,
znajdującą się wewnątrz pętli dopóki, na pętlę dopóki.
"""

"""pseudocode
czy_pierwsza[0] ← fałsz
czy_pierwsza[1] ← fałsz
dla i=2,3,...,n wykonuj
  czy_pierwsza[i] ← prawda
p ← 2
dopóki p * p ⩽ n wykonuj
  jeżeli czy_pierwsza[p]=prawda
  i ← p*p
  dopóki i ⩽ n:
      czy_pierwsza[i] ← fałsz
      i ← i + p
  p ← p + 1
dla i=2,3,...,n wykonuj
  jeżeli czy_pierwsza[i]=prawda to
    wypisz i
"""

"""
Zadanie 4.
Napisz program w języku Python, który wyznaczy wszystkie liczby
pierwsze mniejsze lub równe 1000 metodą sita Eratostenesa, a następnie wyświetli informację
ile liczb w pliku liczby.txt jest liczbą pierwszą. Plik liczby.txt zawiera 10000 liczb z zakresu od 1 do 1000.
"""
plik = open("liczby.txt", "r")
liczby = list(map(int, plik.read().split()))
plik.close()
print(len(liczby))
print(liczby[:10])

"""
Zadanie 5.
Napisz program w języku Python, który zapyta użytkownika o podanie dwóch liczb całkowitych a, b,
gdzie 2<a<b, a następnie wyświetli wszystkie liczby pierwsze z przedziału [a,b] oraz ich liczbę i sumę,
wykorzystując algorytm sita Eratostenesa.
"""
"""
Zadanie 6.
Napisz program w języku Python, który wyznaczy wszystkie liczby pierwsze mniejsze lub równe 1000
metodą sita Eratostenesa. Następnie program wczyta z pliku ciag.txt liczby całkowite z przedziału [1, 1000].
Liczby te są zapisane w jednej linii i są rozdzielone spacjami. Następnie wyświetl ile jest liczb pierwszych
w pliku ciag.txt jest oraz jaki stanowią procent wszystkich liczb.
"""
