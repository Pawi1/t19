# Zadanie 1
print("Zadanie 1: Program, który wypisze ciąg sześcianów liczb naturalnych powiększonych o 3 ")
print("Podaj liczbę:")
n = int(input())
for i in range(n):
 print(i**3 + 3, end=" ")
# Zadanie 2
print("Zadanie 2: Program, który wypisze wszytkie liczby trzycyfrowe podzielne przez 15")

for i in range(105,1000,15):
  print(i, end=" ")
# Zadanie 3
print("Zadanie 3: Program, który wypisze wszyskie dzielniki podanej liczby n")

n = int(input("Podaj liczbę n: "))
for i in range(1, n+1):
 if n%i == 0:
  print(i, end=" ")
# Zadanie 4
print ("Zadanie 4: Program, który obliczy sumę liczb dwucyfrowych")

suma = 0
for i in range(10, 100):
 suma = suma + i
print(suma)

# Zadanie 5
print ("Zadanie 5: Bajtuś postanowił zrobić dla swoich kolegów pewną zagadkę. Zagadka polega na tym, że koledzy najpierw podają liczbę naturalną n. Następnie Bajtuś wybiera sobie liczbę x, taką, że 0 < x < n oraz wypisuje n − 1 różnych, mniejszych on n liczb pomijając przy tym swoje tajemnicze x. Napisz program, który pozwoli sprawdzić, jaką liczbę x wybrał sobie Bajtuś")

n = int(input())
suma = n*(n+1) // 2

for i in range(n-1):
    x = int(input())
    suma = suma - x
print(suma)

# Zadanie 6
print ("Zadanie 6: Napisz program według wyjścia poniżej (ciąg Fibonacciego)")

print("Ile liczb: ")
n = int(input())
a = 0
b = 1
print(a, end=" ")
print(b, end=" ")
for i in range(n-2):
  a,b = b, a+b
  print(b, end=" ")