
# Zadanie 1
print("Zadanie 1: (easy) Sprawdź czy suma dwóch wpisanych przez użytkownika jest liczbą parzystą")

print("Wpisz liczbe a:")
a = int(input())
print("Wpisz liczbe b:")
b = int(input())
if (a+b)%2==0:
    print("Suma a i b jest liczbą parzystą")
else:
    print("Suma a i b nie jest liczbą parzystą")
# Zadanie 2
print("Zadanie 2: (easy) Sprawdź, czy średnia arytmetyczna dwóch wpisanych liczb jest wieksza od jej średniej geometrycznej")
print("Wpisz liczbe a:")
a = int(input())
print("Wpisz liczbe b:")
b = int(input())
art = (a+b)/2
from math import sqrt
geo = (sqrt(a*b))
if art > geo :
    print("Średnia arytmetyczna jest większa od średniej geometrycznej")
else: 
 if geo < art:
    print("Średnia arytmetyczna jest mniejsza od średniej geometrycznej") 
 else:
  if geo == art:
    print("Średnia arytmetyczna jest równa średniej geometrycznej")
# Zadanie 3
print("Zadanie 3: (easy) Użytkownik podaje 3 liczby całkowite. Sprawdź czy dokładnie dwie z nich są sobie równe")
print("Wpisz liczbe a:")
a = int(input())
print("Wpisz liczbe b:")
b = int(input())
print("Wpisz liczbe c:")
c = int(input())
if (a==b) and (a!=c) and (b!=c):
    print("Tylko liczby a i b są siebie równe")
else:
 if (a==c) and (a!=b) and (b!=c):
    print("Tylko liczby a i c są siebie równe")
 else:
  if (b==c) and (c!=a) and (b!=a):
    print("Tylko liczby c i b są siebie równe")
  else:
   print("W tym zbiorze żadna z liczb nie spełnia warunku")
# Zadanie 4
print("Zadanie 4: (medium) Niech użytkownik wprowadzi 4 różne liczby całkowite. Napisz program, który sprawdzi, która z tych liczb jest najmniejsza")
print("Wpisz liczbe a:")
a = int(input())
print("Wpisz liczbe b:")
b = int(input())
print("Wpisz liczbe c:")
c = int(input())
print("Wpisz liczbe d:")
d = int(input())
if a<b and a<c and a<d:
 print("Liczba A jest najmniejsza")
else:
 if b<a and b<c and b<d:
  print("Liczba B jest najmniejsza")
 else:
  if c<a and c<b and c<d:
   print("Liczba C jest najmniejsza")
  else:
   if d<a and d<b and d<c:
    print("Liczba D jest najmniejsza")
   else:
    print("Użytkownik nie wprowadził różnych cyfr")
# Zadanie 5
print("Zadanie 5: Sprawdź czy trzy wprowadzone przez użytkownika liczby spełniają nierówność trójkąta")
print("Wpisz liczbe a:")
a = int(input())
print("Wpisz liczbe b:")
b = int(input())
print("Wpisz liczbe c:")
c = int(input())
if (a+b>=c) or (c+b>=a) or (a+c>=b):
 print("Liczby spełniają nierówność trójkąta")
else:
 print("Liczby nie spełniają nierówność trójkąta")
# Zadanie 6
print("Zadanie 6 : (medium) Niech z trzech wprowadzonych przez użytkwnika liczbach da się zbudować trójąt. Sprawdź czy ten trójką jest ostrokątny, prostokątny czy rozwartokątny")
print("Podaj kąt przy wierzchołku A:")
a = int(input())
print("Podaj kąt przy wierzchołku B:")
b = int(input())
print("Podaj kąt przy wierzchołku C:")
c = int(input())
if (a < 90 and b < 90 and c < 90) and a+b+c == 180:
 print("Z danych kątów da się zrobić trójkąt ostrokątny")
else:
 if ((a == 90  and ( b < 90 and c < 90)) or (b == 90  and ( a < 90 and c < 90)) or (c == 90  and ( b < 90 and a < 90))) and a+b+c == 180:
  print("Z danych kątów da się zrobić trójkąt prostokątny")
 else:
  if ((a > 90  and ( b < 90 and c < 90)) or (b > 90  and ( a < 90 and c < 90)) or (c > 90  and ( b < 90 and a < 90))) and a+b+c == 180:
   print("Z danych kątów da się zrobić trójkąt rozwartokątny")
  else:
   print("Z danych kątów nie da się zrobić trójkąta")         