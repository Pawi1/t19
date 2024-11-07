'''Lekcja dzielniki'''
'''Napisz program, który sprawdzi, czy liczba całkowita dodatnia n podana przez użytkownika dzieli się
przez 2 i wyświetli jeden z komunikatów „Tak”, „Nie”.'''

def czyPodzielnaPrzez2(n):
    if n % 2 == 0:
        return 'Tak'
    else: 
        return 'Nie'
print(czyPodzielnaPrzez2(int(input('1. Podaj n: '))))

'''Napisz program, który wyświetli dzielniki liczby całkowitej dodatniej n podanej przez użytkownika.'''
# n = int(input('2. Podaj n: '))
#for i in range(1,n+1):
#    if n % i == 0:
#        print(i,end=' ')

# wydajniejszy algorym (pierwiastek)
n = int(input('2. Podaj n: '))
i = 1
while i*i<n:
    if n % i == 0:
        print(i)
        print(n/i)
    i = i+1
if i*i == n:
    print(i)


'''Napisz program, który wyświetli sumę dzielników liczby całkowitej dodatniej n podanej przez
użytkownika.'''
n = int(input('3. Podaj n: '))
suma:int = 0
for i in range(1,n+1):
    if n % i == 0:
        suma += i
print(suma)

'''Napisz program, który wyświetli dzielniki pierwsze liczby całkowitej dodatniej n podanej przez
użytkownika.'''
def czyPierwsza(n):
    for i in range(2,n):
        if n % i == 0:
            return False
    return True
n = int(input('4. Podaj n: '))
for i in range(2,n+1):
     if n % i == 0 and czyPierwsza(i):
        print(i)

'''Napisz program, który sprawdzi, czy liczby całkowite dodatnie a i b podane przez użytkownika są
liczbami bliźniaczymi. Liczby całkowite dodatnie są liczbami bliźniaczymi, jeżeli są liczbami
pierwszymi i ich różnica wynosi 2, np. liczby 5 i 7 oraz 11 i 13 są liczbami bliźniaczymi, a 7 i 9 nie są
bliźniacze, bo 9 nie jest liczbą pierwszą.'''
a = int(input('5. Podaj a: '))
b = int(input('5. Podaj b: '))
def czyBlizniacza(a,b):
    if czyPierwsza(a) and czyPierwsza(b) and ((a > b and b+2 == a) or (b > a and a+2 == b)):
        return True
    else:
        return False
if czyBlizniacza(a,b):
    print(f'Liczby {a} i {b} są bliźniacze')
else:
    print(f'Liczby {a} i {b} nie są bliźniacze')

'''Napisz program, który sprawdzi, czy liczba całkowita dodatnia n podana przez użytkownika 
jest liczbą doskonałą. Liczba doskonała, to taka, która jest równa sumie swoich dzielników właściwych (czyli mniejszych od tej liczby). 
Program wyświetli jeden z komunikatów „tak” lub „nie”. Przykładowe liczby doskonałe:
6 = 1+2+3
28 = 1+2+4+7+14
'''
n = int(input('6. Podaj n: '))
suma = 0
for i in range(1,n):
    if n % i == 0
        suma += i
if suma == n:
    print('Tak')
else:
    print('Nie')
'''Napisz program, który sprawdzi, czy liczby całkowite dodatnie a i b podane przez użytkownika są liczbami zaprzyjaźnionymi. 
Liczby całkowite dodatnie a i b są liczbami zaprzyjaźnionymi,  jeżeli są różne oraz suma dzielników właściwych liczby a jest równa liczbie b 
oraz suma dzielników właściwych liczby b jest równa liczbie a. Program wyświetli jeden z komunikatów „tak” lub „nie”. Przykłady liczb zaprzyjaźnionych:
Dzielniki liczby 284: 1, 2, 4, 71, 142
Dzielniki liczby 220: 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, 110
220 = 1 + 2 + 4 + 71 + 142
284 = 1 + 2 + 4 + 5 + 10 + 11 + 20 + 22 + 44 + 55 + 110
Kolejna para liczb zaprzyjaźnionych: 1184 i 1210
'''
