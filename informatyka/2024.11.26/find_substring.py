"""
Znajdowanie podciągów o różnych własnościach.
"""

"""
Zadanie 1.
Napisz program, który wyświetli wszystkie spójne podciągi 
ciągu znajdującego się w pierwszym wierszu pliku liczby.txt w kolejności 
od najkrótszych jednowyrazowych do najdłuższego.
"""
with open("liczby.txt") as file:
    key: list[int] = list(map(int, file.readline().split()))
    for i in range(1, len(key) + 1):  # length of string
        for j in range(len(key) - i + 1):  # index
            print(" ".join(map(str, key[j : j + i])))
"""
Kod autorstwa RadomirSz do pozostałych zadań
"""
plik = open("pi.txt.", "r")
T = list(map(int, plik.read().split()))
plik.close()

print("z1:")
licznik = 0
for i in range(len(T) - 1):
    if T[i] == 9 and T[i + 1] > 0:
        licznik += 1
        # print(i+1, ":", T[i],T[i+1])
print(licznik)

print("z2:")

fragmenty_pi = []
for i in range(len(T) - 1):
    if T[i] != 0:
        fragmenty_pi.append(str(T[i] * 10 + T[i + 1]))
    else:
        fragmenty_pi.append("0" + str(T[i + 1]))

fragmenty_licznik = [0] * 100

for i in fragmenty_pi:
    fragmenty_licznik[int(i)] += 1

maksymalny = 0
minimalny = 0
for i in range(len(fragmenty_licznik)):
    if fragmenty_licznik[i] > fragmenty_licznik[maksymalny]:
        maksymalny = i
    if fragmenty_licznik[i] < fragmenty_licznik[minimalny]:
        minimalny = i
print(
    minimalny,
    ":",
    fragmenty_licznik[minimalny],
    maksymalny,
    ":",
    fragmenty_licznik[maksymalny],
)


print("z3:")

# def isValid(T):
#     if len(T) < 4:
#         return False
#
#
#     rosnie = True
#     if T[0] > T[1]:
#         rosnie = False
#
#     for i in range(1,len(T)):
#         if rosnie and T[i] > T[i-1] or not rosnie and T[i] < T[i-1]:
#             continue
#         if i == len(T):
#             return True
#
#     for i in range(len(T)-1):
#         if (rosnie and T[i] > T[i+1]) or (not rosnie and T[i] < T[i+1]):
#             return False
#
#     return True


flagaNaStart = False
flagaWSrodku = False
rosnacoMalejace = []
temp = []
for i in range(len(T) - 1):
    if not flagaNaStart and T[i] < T[i + 1]:
        flagaNaStart = True
        temp = []
        flagaWSrodku = True

    if flagaNaStart:
        if flagaWSrodku:
            if T[i] <= T[i + 1]:
                temp.append(T[i])
            else:
                flagaWSrodku = False
        else:
            if T[i] > T[i + 1]:
                temp.append(T[i])
            else:
                flagaNaStart = False
                if len(temp) > 3:
                    rosnacoMalejace.append(temp)
print(rosnacoMalejace)


def rosnie(T):
    for i in range(len(T) - 1):
        if T[i] > T[i + 1]:
            return False
    return True


def maleje(T):
    for i in range(len(T) - 1):
        if T[i] < T[i + 1]:
            return False
    return True


def isValid(T):
    if len(T) < 4:
        return False

    indeks = 0
    for i in range(len(T) - 1):
        if T[i] >= T[i + 1]:
            indeks = i
            break

    if not rosnie(T[:indeks]) or not maleje(T[indeks:]):
        return False
    else:
        return True


def f6():
    ciag = list(map(int, input().split()))

    for i in range(1, len(ciag)):
        if ciag[i] <= ciag[i - 1]:
            return "nie"
    return "tak"


print(f6())


def f7():
    ciag = list(map(int, input().split()))

    for i in range(1, len(ciag)):
        if ciag[i] >= ciag[i - 1]:
            return "nie"
    return "tak"


print(f7())


def f8():
    ciag = list(map(int, input().split()))

    for i in range(1, len(ciag)):
        if ciag[i] > ciag[i - 1]:
            return "nie"
    return "tak"


print(f8())


def f9():
    ciag = list(map(int, input().split()))

    for i in range(1, len(ciag)):
        if ciag[i] < ciag[i - 1]:
            return "nie"
    return "tak"


print(f9())


def f10():
    ciag = list(map(int, input().split()))

    for i in range(1, len(ciag)):
        if ciag[i] != ciag[i - 1]:
            return "nie"
    return "tak"


print(f10())

plik = open("liczby.txt", "r")
T = list(map(int, plik.readline().split()))
plik.close()

tempLen = 0
maksLen = 0
for i in range(len(T) - 1):
    if T[i + 1] >= T[i]:
        tempLen += 1
    else:
        tempLen += 1
        if tempLen > maksLen:
            maksLen = tempLen
        tempLen = 0
print(maksLen)

plik = open("liczby.txt", "r")
T = list(map(int, plik.readline().split()))
plik.close()

tempT = []
tempOut = []
for i in range(len(T) - 1):
    if T[i + 1] >= T[i]:
        tempT.append(T[i])
    else:
        tempT.append(T[i])
        if len(tempT) > len(tempOut):
            tempOut = tempT
        tempT = []
print(tempOut)

plik = open("pi_przyklad.txt", "r")
T = list(map(int, plik.read().split()))
plik.close()

print("z1:")
licznik = 0
for i in range(len(T) - 1):
    if T[i] == 9 and T[i + 1] > 0:
        licznik += 1
        # print(i+1, ":", T[i],T[i+1])
print(licznik)

print("z2:")

fragmenty_pi = []
for i in range(len(T) - 1):
    if T[i] != 0:
        fragmenty_pi.append(str(T[i] * 10 + T[i + 1]))
    else:
        fragmenty_pi.append("0" + str(T[i + 1]))

fragmenty_licznik = [0] * 100

for i in fragmenty_pi:
    fragmenty_licznik[int(i)] += 1

maksymalny = 0
minimalny = 0
for i in range(len(fragmenty_licznik)):
    if fragmenty_licznik[i] > fragmenty_licznik[maksymalny]:
        maksymalny = i
    if fragmenty_licznik[i] < fragmenty_licznik[minimalny]:
        minimalny = i
print(
    minimalny,
    ":",
    fragmenty_licznik[minimalny],
    maksymalny,
    ":",
    fragmenty_licznik[maksymalny],
)


print("z3:")


def czyRosnacoMalejaca(T):
    flaga = True
    for i in range(1, len(T)):
        if T[i - 1] > T[i] and flaga:
            return False
        if flaga and T[i - 1] >= T[i]:
            flaga = False
        if not flaga and T[i - 1] < T[i]:
            return False
    return True


rosnacoMalejace = []

for i in range(len(T) - 6):
    temp = T[i : i + 6]
    if czyRosnacoMalejaca(temp):
        rosnacoMalejace.append(temp)
        temp = []


print(rosnacoMalejace)
print(len(rosnacoMalejace))


print("z4:")


# def czyRosnacoMalejaca(T):
#     flaga = True
#     for i in range(1,len(T)):
#         if T[i-1] > T[i] and flaga:
#             return False
#         if flaga and T[i-1] >= T[i]:
#             flaga = False
#         if not flaga and T[i-1] < T[i]:
#             return False
#     return True

M = []
Mindeks = 0

for i in range(len(T) - 1):
    for j in range(i + 1, len(T)):
        temp = T[i:j]
        # print(temp)
        if czyRosnacoMalejaca(temp):
            if len(temp) > len(M):
                Mindeks = i + 1
                M = temp
        else:
            break

print(M, Mindeks)

plik = open("wyniki3.txt", "w")
doPliku1 = f"zadanie 3.1. \n{licznik}"
doPliku2 = f"\n\nzadanie 3.2. \n{minimalny} {fragmenty_licznik[minimalny]} \n{maksymalny} {fragmenty_licznik[maksymalny]} "
doPliku3 = f"\n\nzadanie 3.3. \n{len(rosnacoMalejace)}"
doPliku4 = f"\n\nzadanie 3.4. \n{Mindeks}\n{M}"
plik.write(doPliku1)
plik.write(doPliku2)
plik.write(doPliku3)
plik.write(doPliku4)
plik.close()
