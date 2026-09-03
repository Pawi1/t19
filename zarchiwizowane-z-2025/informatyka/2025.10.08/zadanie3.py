"""
Napisz program, który wczyta macierz M z pliku macierz.txt, a następnie wyświetli tą macierz z zamienionymi kolumnami o indeksach 2 i 4.
* podczas wypisywania uzupełnij liczby jednocyfrowe dodatkową spacją z przodu
"""
matrix:list[list[str]] = []
with open("macierz.txt") as file:
    for line in file.readlines():
        cline:list[str] = []
        for number in line.split():
            if(len(number) == 1):
                number = " "+str(number)
            cline.append(number)
        matrix.append(cline)

for row in matrix:
    row = [row[0],row[1],row[4],row[3],row[2],row[5]]
    print(" ".join(str(d) for d in row))
    #print("".join(str(d) for d in row))

""" alternatywnie
for row in matrix:
    row = [row[0],row[1],row[4],row[3],row[2],row[5]]
    print(row)
"""