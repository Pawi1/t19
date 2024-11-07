lista = []
from random import randint
for _ in range(9):
    lista.append(randint(0,1)) 
def lider(lista):
    count = 1
    k = 0
    for i in range(lista[k+1],len(lista)):
        if count == 0:
            k = i
            count = 1
        else:     
            if lista[i] == lista[k]:
                count+=1
            else:
                count-=1
    if count == 0:
        return None
    else:
        count = 0
        for i in lista:
            if i == lista[k]:
                count += 1
    if count > len(lista)/2:
        return lista[k]
    else:
        return None
print(lista)
print(lider(lista))