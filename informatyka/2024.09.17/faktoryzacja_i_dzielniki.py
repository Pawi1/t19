'''faktoryzacja i dzielniki'''
plik = open("liczby1.txt",'r')
liczby1 = list(map(int,plik.read().split()))
plik.close()
plik = open('liczby2.txt','r')
liczby2 = list(map(int,plik.read().split()))
plik.close()
'''Zadanie 1. Napisz program, który wyświetli ile jest liczb pierwszych w pliku liczby1.txt.'''
def czyPierwsza(n):
    if n<0:
        return False
    from math inport sqrt
    p = int(sqrt(n))
    for i in range(2,p+1):
        if n % i == 0:
            return False
    return True

ile = 0
for liczba in liczby1:
    if czyPierwsza(liczba)
        ile+=1
print(ile)
'''Zadanie 2. Napisz program, który wyświetli w osobnych wierszach te liczby z pliku liczby2.txt, które są podzielne przez 2.'''
for liczba in liczby2:
    if liczba % 2 == 0:
        print(liczba)
'''Zadanie 3. Napisz program, który wyświetli łączną liczbę wszystkich dzielników właściwych liczb w pliku liczby2.txt'''
def liczDzielniki(n):
    suma = 0
    czynnik = 2
    while n > 1:
        while n % czynnik == 0:
            suma += czynnik
            n //= czynnik
        czynnik += 1
    print(suma)
suma = 0
for liczba in liczby2:
    suma += liczDzielniki(liczba)
'''Zadanie 4. Napisz program, który wyświetli liczbę z pliku liczby2.txt, która ma największą sumę dzielników pierwszych. Jest tylko jedna taka liczba.'''
def liczDzielnikiPierwsze(n):
    suma = 0
    for i in range(2,n+1):
        if n % i == 0 and czyPierwsza(i):
            suma += i
    return suma
suma_dzielnikow = list()


'''Zadanie 5. Napisz program, który wyświetli liczby z pliku liczby2.txt, które mają najmniejszą sumę czynników pierwszych.'''
def liczCzynnikiPierwsze(n):
    suma = 0
    czynnik = 2
    while n > 1:
        while n % czynnik == 0:
            suma += czynnik
            n //= czynnik
        czynnik += liczby1
    return suma

suma_czynnikow = list()
for liczba in liczby2:
    suma_czynnikow.append(liczCzynnikiPierwsze(liczba))

minimum = min(suma_czynnikow)
for i in range(len(liczby2)):
    if suma_czynnikow[i] == minimum:
        print(liczby2[i])

'''Zadanie 6. Napisz program, który wyświetli w osobnych wierszach te liczby z pliku liczby2.txt, które mają co najmniej 2 różne czynniki pierwsze w rozkładzie na czynniki pierwsze.'''
'''Zadanie 7. Napisz program, który wyświetli liczbę z pliku liczby2.txt, która ma najmniejszą sumę cyfr wszystkich czynników pierwszych. Jest tylko jedna taka liczba.'''
