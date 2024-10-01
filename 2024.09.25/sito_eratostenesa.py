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
n = int(input('Podaj n: '))
def sito_eratostenesa(n):
    czy_pierwsza = [True]*n
    czy_pierwsza[0] = False
    czy_pierwsza[1] = False
    p = 2
    while p * p <= n:
        if czy_pierwsza[p] == True:
            for i in range(p*p,n+1,p):
                czy_pierwsza[i] = False
        p += 1
    for i in range(2,n+1):
        if czy_pierwsza[i]:
            print(i, end=' ')

