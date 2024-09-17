'''faktoryzacja i dzielniki'''
plik = open("liczby1.txt",'r')
liczby1 = list(map((int,plik.read().split())))
plik.close()

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

