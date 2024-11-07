# Zadanie 1
print("Zadanie 1: (very easy) Napisz pętle wypisujacą dni miesiąca listopada 2022 roku")
print("\t\tLISTOPAD 2022")

print("\t",end="")
for i in range(1,31):
 if (i == 0): print("\t")
 if (i != 0): print(f"{i}\t")
 if (i == 6 or i == 13 or i == 20 or i == 27): print("\n")

# Zadanie 2
print("Zadanie 2: (easy) Napisz pętle wypisujacą kwadraty cyfr nieparzystych")
from cmath import sqrt
for i in range(1,1000100,2):
  print(Sqrt(i))

# Zadanie 3
print("Zadanie 3: (easy) Napisz pętle wypisującą liczby czterocyfrowe dzielące się przez 379")
for i in range(1000,10000):
    if i % 379 == 0:
        print(i)

# Zadanie 4
print("Zadanie 4: (medium) Napisz pętle wypisującą liczby trzycyfrowe podzielne przez 5, 6 lub ewentualnie 11")
for i in range(100,1000):
    if (i % 5 == 0 and i % 6 == 0) or i % 11 == 0:
        print(i)

# Zadanie 5
print("Zadanie 5: (medium) Napisz program, który podaje sumę wpisanych przez usera liczb. User najpierw podaje ile liczb poda, a potem w pętli te liczby są czytane")
ilosc = int(input("Podaj ilość liczb: "))
Liczby = []
for i in range(0,ilosc):
    temp = int(input(f"Podaj {i+1} liczbę: "))
    Liczby.append(temp)
print(f"Wynik to: {sum(Liczby)}")

# Zadanie 6
print("Zadanie 6: (light hard) Napisz program wyznaczający sumę k początkowych liczb parzystych")
ilosc = int(input("Podaj liczby: "))
suma = 0
for i in range(2,(ilosc*2)+2,+2):
    suma += i
print(f"Suma to: {suma}")

# Zadanie 7
print("Zadanie 7 (light hard) Napisz program wyznaczający sumę m początkowych dwucyfrowych liczb nieparzystych")
ilosc = int(input("Podaj liczby: "))
suma = 0
for i in range(11,(ilosc*2)+11,+2):
    suma += i
print(f"Suma to: {suma}")

# Zadanie 8
print("Zadanie 8:(light hard) Napisz program, który W PĘTLI obliczy wartość inwestycji, która jest kapitalizowana co miesiąc w stosunku 6% rocznie. User podaje kwotę wejściową W0 oraz okres inwestycji w latach L z dokładnością do pół roku")
w0 = int(input("Podaj wartość początkową inwestycji: "))
L = int(input("Ile lat ma trwać inwestycja: "))
wartosc = 0
suma = w0
for i in range(0,L * 12):
    wartosc = suma * 0.06 * (1/12)
    suma += wartosc
print(f"Końcowy kapitał wynosi: {suma}")

# Zadanie 9
print("Zadanie 9: (hard) Napisz program wyznaczający sumę n początkowych liczb kończących się liczbą 21")
ilosc = int(input("Podaj ilość liczb: "))
l = 21
suma = 0
for i in range(0,ilosc+1):
    for a in range(0,i,l):
        print(l)
        suma += l
        l += 100
print(f"Suma to: {suma}")

# Zadanie 10
from cmath import sqrt
print("Zadanie 10: (hard) Napisz program wyznaczający wszystkie liczby od 1 do 1000, które kończą się swoim pierwiastkiem")
for i in range(1,1000):
    if i % 10 == sqrt(i):
        print(i)
    elif i % 100 == sqrt(i):
        print(i)