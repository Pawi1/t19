"""
Napisz program, który wczyta macierz M z pliku macierz.txt, wypisze maksymalną sumę elementów leżących na ścieżce od lewego górnego rogu do prawego dolnego, wyznaczoną algorytmem zachłannym. Można poruszać się po macierzy tylko w prawo i w dół. Przyjmij, że jeżeli elementy sąsiadujące, położone na prawo lub na dół od aktualnej wartości są równe, to wybieramy drogę w dół. Program powinien wyświetlić obliczoną maksymalną sumę oraz napis składający się z liter P oraz D, gdzie litera P oznacza pójście w prawo, a litera D pójście w dół.
"""
matrix:list[list[int]] = []
with open("macierz.txt") as file:
    for line in file.readlines():
        matrix.append(list(map(int,line.rsplit(" "))))

path:str = ""
rows:int = len(matrix)
cols:int = len(matrix[0])
r:int = 0
c:int = 0
m_sum:int = matrix[0][0]
while not (r == rows - 1 and c == cols - 1):
    if r == rows - 1:
        c += 1
        path += "P"
        m_sum += matrix[r][c]
    elif c == cols - 1:
        r += 1
        path += "D"
        m_sum += matrix[r][c]
    else:
        right = matrix[r][c+1]
        down = matrix[r+1][c]
        if down >= right:
            r += 1
            path += "D"
            m_sum += matrix[r][c]
        else:
            c += 1
            path += "P"
            m_sum += matrix[r][c]
print(m_sum)
print(path)

"""
 4  2  1 12  4  3
 2  3  5  1 12  5
11  4  3 15  1  2
 2  8  3 10  4  6
11  2  6  4  1  5
 4 12  7  3 12  1

poprawne:
4+2+11+4+8+3+10+4+3+12+1 = 62
DDPDPPDDPP
"""
