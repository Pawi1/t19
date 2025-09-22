"""
4
12 23 34 45
3
0 4
1 3
3 2
"""

n:int = int(input()) # liczba stacji
c:list[int] = list(map(int,input().split(' '))) # ceny pomiędzy stacjami, i-1..i
k:int = int(input()) # klienci
k_stacje:list[list[int]] = [] # poczatek i koniec dla kazdego klienta
for i in range(k):
    k_stacje.append(list(map(int,input().split(' '))))

for i in range(1,k+1):
    a:int = k_stacje[i-1][0]
    b:int = k_stacje[i-1][1]
    print(f"{a} {b}",end="")
    sum_c:int = 0
    if b>a:
        for i in range(a,b):
            sum_c += c[i]
    elif a>b:
        for i in range(b,a,-1):
            sum_c += c[i]
    else:
        sum_c += c[a]
    print(sum_c)