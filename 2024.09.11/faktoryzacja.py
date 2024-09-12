''' Faktoryzacja - rozkład na czynniki pierwsze (przedstawienie liczby jako iloczyn liczb pierwszych) '''
'''
Przykład  1
Napisz specyfikację i algorytm w postaci pseudokodu, który wyświetli czynniki pierwsze liczby naturalnej n>1.
Specyfikacja:
Dane:
n - liczba naturalna większa od 1
Wyniki:
czynniki pierwsze liczby n

Zadanie 1
Napisz program, który wczyta liczbę naturalną n>1 z klawiatury i wyświetli czynniki pierwsze liczby n w osobnych liniach. 
Np. dla liczby n=100 zostaną wyświetlone liczby
2
2
5
5
bo 100=2*2*5*5
'''

n = int(input('1. Podaj n: '))
czynnik = 2
while n > 1:
    while n % czynnik == 0:
        print(czynnik)
        n = n // czynnik
    czynnik += 1

'''
Zadanie 2
Napisz program, który wczyta liczbę naturalną n>1 z klawiatury i wyświetli sumę czynników pierwszych tej liczby.
Np. dla liczby n=100 zostanie wyświetlona liczba
14
bo 100=2*2*5*5 oraz 2+2+5+5=14    
'''
n = int(input('2. Podaj n: '))
suma = 0
czynnik = 2
while n > 1:
    while n % czynnik == 0:
        suma += czynnik
        n = n // czynnik
    czynnik += 1
print(suma)
'''
Zadanie 3
Napisz program, który wczyta liczbę naturalną n>1 z klawiatury i wyświetli komunikat, czy suma czynników pierwszych liczby n jest liczbą pierwszą.
Wskazówka:
Algorytm badania, czy liczba jest liczbą pierwszą:
Specyfikacja:
Dane:
n - liczba całkowita większa od 1
Wyniki:
komunikat "Tak", gdy n jest liczbą pierwszą; "Nie", gdy n nie jest liczbą pierwszą
'''
n = int(input('3. Podaj n: '))
def czyPierwsza(n):
    if n < 2:
        return 'Nie'
    i = 2
    while i*i <= n:
        if n % i == 0:
            return 'Nie'
        i += 1
    return 'Tak'
suma = 0
czynnik = 2
while n > 1:
    while n % czynnik == 0:
        suma += czynnik
        n = n // czynnik
    czynnik += 1
print(czyPierwsza(suma))
'''
Zadanie 4
Napisz program, który wyświetli liczbę różnych czynników pierwszych liczby n podanej przez użytkownika.
Np. liczba 100 = 2*2*5*5, czyli ma cztery czynniki pierwsze ale tylko dwa różne 2 i 5. Czyli dla liczby n=100 program powinien wyświetlić 2.
'''
n = int(input('4. Podaj n: '))
czynnik = 2
lista = []
while n > 1:
    while n % czynnik == 0:
        flag = True
        for j in lista: 
            if j == czynnik:
               flag = False 
        if flag:
            lista.append(czynnik)
        n = n // czynnik
    czynnik += 1
print(len(lista))
'''
Zadanie 5
Napisz program, który sprawdzi, czy liczba naturalna n>1 podana przez użytkownika jest liczbą Smitha.
Wskazówka:
https://pl.wikipedia.org/wiki/Liczba_Smitha
Przykład: cyfry liczby 123
123 mod 10 = 3
123 div 10 = 12
12 mod 10 = 2
12 div 10 = 1
1 mod 10 = 1
1 div 10 = 0
Algorytm, który oblicza sumę cyfr liczby dziesiętnej:
Specyfikacja:
Dane:
n - liczba całkowita dodatnia
Wyniki:
suma cyfr liczby n w systemie dziesiętnym
'''
n = int(input('5. Podaj n: '))
czynnik = 2
lista = []
while n > 1:
    while n % czynnik == 0:
        flag = True
        for j in lista: 
            if j == czynnik:
               flag = False 
        if flag:
            lista.append(czynnik)
        n = n // czynnik
    czynnik += 1
suma = 0
for i in str(n):
    suma += i
if suma == len(lista):
    print('Tak')
else:
    print('Nie')
