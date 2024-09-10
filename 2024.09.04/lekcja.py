"""Napisz program, który sprawdzi, czy liczba całkowita dodatnia n podana przez użytkownika dzieli się
przez 2 i wyświetli jeden z komunikatów „Tak”, „Nie”."""

def czyPodzielnaPrzez2(n):
    if n % 2 == 0:
        return 'Tak'
    else: 
        return 'Nie'
print(czyPodzielnaPrzez2(int(input('Podaj liczbe n: '))))

'''Napisz program, który wyświetli dzielniki liczby całkowitej dodatniej n podanej przez użytkownika."""
n = int(input('Daj n: '))'''
for i in range(1,n+1):
    if n % i == 0:
        print(i,end=' ')

'''Napisz program, który wyświetli sumę dzielników liczby całkowitej dodatniej n podanej przez
użytkownika.'''
n = int(input('Daj n: '))
suma:int = 0
for i in range(1,n+1):
    if n % i == 0:
        suma += i
print(suma)

'''Napisz program, który wyświetli dzielniki pierwsze liczby całkowitej dodatniej n podanej przez
użytkownika.'''
n = int(input(''))

'''Napisz program, który sprawdzi, czy liczby całkowite dodatnie a i b podane przez użytkownika są
liczbami bliźniaczymi. Liczby całkowite dodatnie są liczbami bliźniaczymi, jeżeli są liczbami
pierwszymi i ich różnica wynosi 2, np. liczby 5 i 7 oraz 11 i 13 są liczbami bliźniaczymi, a 7 i 9 nie są
bliźniacze, bo 9 nie jest liczbą pierwszą.'''
