"""
4
12 23 34 45
3
0 4
1 3
3 2
"""

n:int = int(input())
c_map:list = list(map(int,input().split(' ')))
c:list[int] = [c_map[0]]
for i in range(1,len(c_map)):
    c.append(c[i-1] + c_map[i])
c = [0]+c
rtn:str = ""
k:int = int(input()) # klienci
for i in range(k):
    k_stacje:list = list(map(int,input().split(' ')))
    rtn += str(abs(c[k_stacje[1]]-c[k_stacje[0]]))+"\n"

print(rtn)