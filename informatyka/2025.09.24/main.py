def findMaxSum(M:list[list[int]] ,n:int)->int:
    y:int = 0
    x:int = 0
    sum:int = M[0][0]
    while(y < n-1 and x < n-1):
        if y == n-1:
            x+=1
        elif x == n-1:
            y+=1
        elif M[y+1][x] > M[y][x+1]:
            y +=1
        else:
            x +=1
        sum += M[y][x]
    return sum

"""
Zadanie 3
Napisz program, który utworzy macierz M wypełnioną liczbami z zadania 2 i wypisze maksymalną sumę otrzymaną zgodnie z algorytmem zachłannym opisanym powyżej.
"""
M:list[list[int]] = [
    [3,7,2,6,4],
    [5,1,9,3,8],
    [6,2,4,7,1],
    [8,3,5,2,9],
    [4,6,1,5,7]
]
print(findMaxSum(M,len(M)))
"""
Zadanie 4
Napisz program, który wczyta macierz M z pliku macierz.txt i wypisze maksymalną sumę oraz indeksy wybieranych komórek w osobnych wierszach rozdzielone spacjami.
"""
M:list[list[int]] = []
with open("macierz.txt") as file:
    preM:list[str] = file.readlines()
    for string in preM:
        M.append(list(map(int,string.split())))

def findMaxSumWithOutput(M:list[list[int]] ,n:int):
    y:int = 0
    x:int = 0
    outputStr:str = ""
    sum:int = M[0][0]
    while(y < n-1 and x < n-1):
        if y == n-1:
            x+=1
        elif x == n-1:
            y+=1
        elif M[y+1][x] > M[y][x+1]:
            y +=1
        else:
            x +=1
        outputStr+=f"{y} {x}\n"
        sum += M[y][x]
    return [sum,outputStr]
result = findMaxSumWithOutput(M,len(M))
print(result[0])
print(result[1])