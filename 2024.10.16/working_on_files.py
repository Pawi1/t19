"""
Przetwarzanie plików i operacje na napisach
"""

"""
Zadanie 1.
Napisz program, który zapyta użytkownika o podanie imienia i nazwiska, a 
następnie zapisze te dane w pliku dane_osobowe.txt
w dwóch wierszach (pierwszy wiersz imię, drugi nazwisko).
"""
user_name: str = input("Zadanie 1:\nPodaj imię: ")
user_surname: str = input("Podaj nazwisko: ")
file = open("dane_osobowe.txt", "w")
file.write(user_name + "\n" + user_surname)
file.close()
file = None
"""
Zadanie 2.
Napisz program, który odczyta imię i nazwisko zapisane w pliku dane_osobowe.txt
i wyświetli powitanie „Witaj imię i nazwisko”, gdzie 
imię i nazwisko należy zastąpić odczytanymi z pliku tekstowego.
"""
file = open("dane_osobowe.txt")
user_info = file.read().rstrip().split()
print(f"Witaj {user_info[0]} {user_info[1]}")
file.close()
file = None
"""
Zadanie 3.
Napisz program, który:
zapisze w pliku losowe.txt 10 liczb losowych z zakresu od 1 do 100 w osobnych liniach.
wyświetli sumę, minimum, maksimum, średnią liczb odczytanych z pliku losowe.txt
"""
from random import randint

file = open("losowe.txt", "w")
for i in range(10):
    file.write(str(randint(1, 100)) + "\n")
file.close()
file = open("losowe.txt")
numbers = map(int, file.read().rstrip().split())
print(sum(numbers))
print(min(numbers))
print(max(numbers))
print((min(numbers) + max(numbers)) / 100)
