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
numbers = list(map(int, file.read().rstrip().split()))
print(sum(numbers))
print(min(numbers))
print(max(numbers))
print((min(numbers) + max(numbers)) / 100)
file.close()
"""
Zadanie 4.
Napisz program, który wyświetli liczbę ciągów z pliku ciagi.txt, 
które mają sumę wyrazów parzystą. Opis zawartości pliku ciagi.txt znajduje się 
w przykładzie 6.
"""
file = open("ciagi.txt")
sum_of_even: int = 0
for line in file:
    sequence: list[int] = list[int](map(int, line.split()))
    if sum(sequence) % 2 == 0:
        sum_of_even += 1
print(sum_of_even)
file.close()
"""
Zadanie 5.
Napisz program (każdy podpunkt jako osobny program), który odczyta plik slowa.txt, a następnie:
- wyświetli ponumerowane słowa z pliku tekstowego
- wyświetli liczbę słów w pliku
- wyświetli słowa zaczynające się na literę A
- wyświetli słowa kończące się na literę A
- wyświetli słowa oraz liczbę liter, z których się składają
- *wyświetli najkrótsze oraz najdłuższe słowo w pliku oraz ich długość (jeżeli jest ich kilka wyświetl pierwsze z nich)
- wyświetli słowa o długości 6
- wyświetli słowa zawierające literę O oraz dla każdego z tych słów liczbę tych liter O
- wyświetli ile razy w całym pliku występuje litera A
"""
with open("slowa.txt") as file:
    i: int = 1
    for line in file:
        print(str(i) + " " + line.rstrip())
        i = +1
"""
- wyświetli liczbę słów w pliku
"""
with open("slowa.txt") as file:
    i: int = 1
    for line in file:
        i = +1
    print(i)
"""
- wyświetli słowa zaczynające się na literę A
"""
with open("slowa.txt") as file:
    for line in file:
        if line[0] == "A":
            print(line)

"""
Zadanie 7.
Napisz program, który:
zapisze w pliku losowe_w_linii.txt 20 liczb losowych z zakresu od 1 do 10 w jednej linii rozdzielone spacją (po ostatniej liczbie powinien być znak nowej linii).
wyświetli liczby, które występują najczęściej
"""
with open("losowe_w_linii.txt", "w") as file:
    from random import randint

    for i in range(20):
        file.write(str(randint(1, 10)) + " ")
with open("losowe_w_linii.txt") as file:
    freq: list[int] = list(0 for _ in range(10))
    for i in range(10):
        for number in file:
            if number == i:
                freq[i] += 1
    max: int = -1
    max_number: int = -1
    for i in range(10):
        if freq[i] > max:
            max_number = freq[i]
    print(file.readlines())
    print("Najczęstszą liczbą jest: " + str(max_number))
