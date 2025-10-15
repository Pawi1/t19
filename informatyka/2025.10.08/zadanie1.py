"""
Napisz program w języku Python, który wczyta nominały zapisane w pierwszej linii pliku dane.txt i rozdzielone spacjami, potem wczyta 10 kwot znajdujących się w dziesięciu kolejnych liniach pliku. Następnie program wyświetli kwotę, która w algorytmie zachłannym wydawania reszty wymaga najmniejszej liczby nominałów. Jeżeli jest kilka takich kwot, to wypisz wszystkie z nich.
"""
nominaly:list[int] = []
kwoty:list[int] = []
with open("dane.txt") as dane:
    nominaly = list(map(int,dane.readline().rsplit(" ")))
    kwoty = list(map(int,dane.read().rsplit()))

def zachlanne(kwota: int) -> int | None:
    amount = 0
    remaining = kwota
    for nominal in nominaly:
        cnt = remaining // nominal
        amount += cnt
        remaining %= nominal
    if remaining != 0:
        return None
    return amount


best:list[list] = [[kwoty[0],zachlanne(kwoty[0])]]
for kwota in kwoty[1:]:
    amount:int | None = zachlanne(kwota)
    if amount == None:
        continue
    if amount < best[0][1]:
        best.clear()
        best.append([kwota,amount])
    elif amount == best[0][1]:
        best.append([kwota,amount])

print([item[0] for item in best])