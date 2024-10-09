"""
Szukanie binarne
"""

"""
Przykład 1
Napisz algorytm w postaci pseudokodu, który zwróci Prawda lub Fałsz w zależności od tego, czy liczba a należy do uporządkowanej niemalejąco tablicy T[0..n-1], czy nie należy.
Specyfikacja:
Dane:
a – liczba całkowita
n – liczba całkowita dodatnia n oznaczającą liczbę elementów w tablicy T
T[0..n-1] – tablica zawierająca n liczb całkowitych uporządkowanych niemalejąco
Wyniki:
Wartość Prawda, gdy a należy do tablicy T, Fałsz w przeciwnym przypadku
"""


def binarySearch(T: list[int], a: int) -> bool:
    n = len(T)
    left = 0
    right = n - 1
    while left < right:
        middle = (left + right) // 2
        if T[middle] < a:
            left = middle + 1
        else:
            right = middle
    return T[left] == a


"""
Zadanie 1.
Napisz program, który wczytuje ze standardowego wejścia ciąg 10 uporządkowanych niemalejąco liczb całkowitych t[0..9].
Następnie program zapyta o liczbę całkowitą a i wyświetli na standardowym wyjściu tekst „tak”, gdy liczba a znajduje się wśród liczb t[0..9] oraz tekst „nie” w przeciwnym przypadku.
Wykorzystaj wyszukiwanie binarne w wersji iteracyjnej.
W przypadku podania przez użytkownika ciągu, który nie jest uporządkowany niemalejąco program wyświetli komunikat „Ciąg musi być uporządkowany niemalejąco”.
"""


def giveFromUserInts() -> list:
    i = 0
    ints = list()
    while i < 10:
        userInput = int(input(f"Podaj {i+1} liczbe: "))
        if len(ints) == 0:
            ints.append(userInput)
            i += 1
        elif ints[i - 1] < userInput:
            ints.append(userInput)
            i += 1
        else:
            print("Ciąg musi być uporządkowany niemalejąco")
    return ints


# a = int(input("Zadanie 1: Podaj a:"))
# if binarySearch(giveFromUserInts(), a):
#    print("tak")
# else:
#    print("nie")
"""
Zadanie 2.
Wykonaj zadanie 1 wykorzystując wyszukiwanie binarne w wersji rekurencyjnej.
"""


def binarySearchreku(T: list[int], a: int, left: int = 0, right: int = -1) -> bool:
    if right == -1:
        right = len(T) - 1
    if left > right:
        return False
    middle = (left + right) // 2

    if T[middle] == a:
        return True
    elif T[middle] < a:
        return binarySearchreku(T, a, middle + 1, right)
    else:
        return binarySearchreku(T, a, left, middle - 1)


# a = int(input("Zadanie 2: Podaj a:"))
# if binarySearchreku(giveFromUserInts(), a):
#    print("tak")
# else:
#    print("nie")
"""
Zadanie 3.
Napisz program, który wyświetli na standardowym wyjściu te ciągi liczbowe z pliku ciagi.txt, 
które zawierają liczbę 10. Wykorzystaj wyszukiwanie binarne. 
W pliku ciagi.txt każdy wiersz zawiera jeden ciąg liczb całkowitych rozdzielonych spacjami.
"""
file = open("ciagi.txt")
sequences = map(str, file.read().split("\n"))
file.close()

for sequence in sequences:
    if sequence == "":
        break
    if binarySearch(list(map(int, sequence.split())), 10):
        print(sequence)
"""
Zadanie 4.
Napisz program, który wyświetli na standardowym wyjściu te ciągi liczbowe z pliku ciagi2.txt, które zawierają liczbę 10. Wykorzystaj wyszukiwanie binarne. W pliku ciagi2.txt:
Pierwszy wiersz – liczba ciągów w pliku
Drugi wiersz – ile jest liczb w kolejnym wierszu
Trzeci wiersz – pierwszy ciąg, który ma tyle liczb rozdzielonych spacją ile wskazuje liczba w poprzednim wierszu.
Czwarty wiersz – ile jest liczb w kolejnym wierszu
Piąty wiersz – drugi ciąg, który ma tyle liczb rozdzielonych spacją ile wskazuje liczba w poprzednim wierszu.
itd.
"""
file = open("ciagi2.txt")
n = int(file.readline().rstrip())
for i in range(n):
    d = int(file.readline().strip())
    sequence = list(map(int, file.readline().split()))
    if binarySearch(sequence, 10):
        print(sequence)
file.close()
"""
Zadanie 5.
Napisz algorytm w formie pseudokodu przyjmując, że elementy tablicy T indeksowane są od 1.
Specyfikacja:
Dane:
a – liczba całkowita
n – liczba całkowita dodatnia n oznaczającą liczbę elementów w tablicy T
T[1..n] – tablica zawierająca n liczb uporządkowanych niemalejąco
Wyniki:
Wartość Prawda, gdy a należy do tablicy T, Fałsz w przeciwnym przypadku
"""
"""pseudocode

"""
"""
Zadanie 6.
Napisz program, który wylosuje 1 000 000 liczb w kolejności rosnącej. 
Wylosuj pierwszą liczbę z przedziału od 1 do 10, a każdą następną dodając do poprzedniej liczby liczbę losową od 1 do 3. 
Następnie sprawdź, czy wśród wylosowanych liczb jest liczba 1 500 000, zapisując w pliku zadanie4.txt jeden z komunikatów „tak” lub „nie” 
w zależności od tego, czy ta liczba jest, czy nie jest wśród wylosowanych. Ponadto wyświetl w nowej linii liczbę porównań z liczbą 1 500 000.
"""
# from random import randint
