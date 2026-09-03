"""
Napisz program, który wczyta macierz M z pliku macierz.txt, a następnie wyświetli największą sumę wartości znajdujących się w jednej kolumnie oraz po spacji indeks pierwszej kolumny o największej sumie.
"""
matrix:list[list[int]] = []
with open("macierz.txt") as file:
    for line in file.readlines():
        matrix.append(list(map(int,line.rsplit(" "))))

best:tuple[int,int] = -1,-1
for x in range(len(matrix[0])):
    sum = 0
    for y in range(len(matrix)):
        sum += matrix[y][x]
    if sum > best[0]:
        best = sum,x

print(f"{best[0]} {best[1]}")