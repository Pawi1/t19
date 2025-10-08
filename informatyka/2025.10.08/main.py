"""
Napisz program w języku Python, który wczyta nominały zapisane w pierwszej linii pliku dane.txt i rozdzielone spacjami, potem wczyta 10 kwot znajdujących się w dziesięciu kolejnych liniach pliku. Następnie program wyświetli kwotę, która w algorytmie zachłannym wydawania reszty wymaga najmniejszej liczby nominałów. Jeżeli jest kilka takich kwot, to wypisz wszystkie z nich.
"""
nominaly:list[int] = []
kwoty:list[int] = []
with open("dane.txt") as dane:
    nominaly = list(map(int,dane.readline().rsplit(" ")))
    kwoty = list(map(int,dane.read().rsplit()))

def zachlanne(kwota:int)->int:
    amount:list[int] = []
    for nominal in nominaly:
        amount.append(kwota // nominal)
        kwota %= nominal
    return len(amount)

best:list[dict] = [{kwota:kwoty[0],amount:zachlanne(kwoty[0])}]
for kwota in kwoty[1:]:
    pass