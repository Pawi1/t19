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
    key:list[int] = list(map(int,file.readline().split()))
    for i in range(1,len(key)+1): # length of string
        for j in range(len(key)-i+1): # index
            print(' '.join(map(str,key[j:j+i])))