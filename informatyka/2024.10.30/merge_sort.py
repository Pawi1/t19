"""
Merge Sort
"""

"""
Zadanie 1.
Napisz program, który wczyta z klawiatury ciąg liczb rozdzielonych spacjami, a 
następnie posortuje ten ciąg za pomocą algorytmu przedstawionego w przykładzie i wyświetli po posortowaniu.
"""
sequence: list[int] = [int(i) for i in input("Podaj ciąg liczb: ").split()]
help_list: list[int] = [0] * len(sequence)


def merge(
    t_list: list[int], left: int, middle: int, right: int, help_list: list[int]
) -> None:
    i: int = left
    j: int = middle + 1
    k: int = left
    while i <= middle and j <= right:
        if t_list[i] < t_list[j]:
            help_list[k] = t_list[i]
            i += 1
        else:
            help_list[k] = t_list[j]
            j += 1
        k += 1
    while i <= middle:
        help_list[k] = t_list[i]
        i += 1
        k += 1
    while j <= right:
        help_list[k] = t_list[j]
        j += 1
        k += 1
    for i in range(left, right + 1):
        t_list[i] = help_list[i]


def sort(t_list: list[int], left: int, right: int):
    if left < right:
        middle = (left + right) // 2
        sort(t_list, left, middle)
        sort(t_list, middle + 1, right)
        merge(t_list, left, middle, right, help_list)


sort(sequence, 0, len(sequence) - 1)
print(sequence)
"""
Zadanie 2.
Napisz program w języku Python, który wczyta dwa uporządkowane niemalejąco ciągi liczb całkowitych, rozdzielonych spacją z pliku ciagi.txt.
Następnie program wyświetli oraz zapisze do pliku winiki_2.txt ciąg liczb rozdzielonych spacjami, uporządkowany niemalejąco, składający się 
z liczb obu wczytanych ciągów. Nie musisz wykorzystywać pseudokodu z przykładu.
"""
def merge2(list1:list[int],list2:list[int]) -> list[int]:
    output_list:list[int] = []
    i:int = 0
    j:int = 0
    len_list1:int = len(list1)
    len_list2:int = len(list2)
    while i < len_list1 and j < len_list2:
        if list1[i] < list2[j]:
            output_list.append(list1[i])
            i += 1
        else:
            output_list.append(list2[j])
            j += 1
    output_list.extend(list1[i:])
    output_list.extend(list2[j:])
    return output_list
def sort2(input_list:list[int]) -> list[int]:
    len_list = len(input_list)
    if len_list > 1:
        middle:int = (len_list-1) // 2
        left:list[int] = sort2(input_list[:middle+1])
        right:list[int] = sort2(input_list[middle+1:])
        return merge2(left,right)
    return input_list

lists:list[list[int]] = []
with open('ciagi.txt', 'r') as file:
    for line in file:
        lists.append(list(map(int,line.rstrip().split())))
with open('wyniki_2.txt','w') as file:
    file.write(' '.join(map(str,merge2(lists[0],lists[1]))))
"""
Zadanie 3.
Napisz program w języku Python, który wylosuje milion liczb
z zakresu od 1 do miliona, a następnie program zapisze ten ciąg posortowany 
metodą sortowania przez scalanie do pliku wyniki_3.txt (liczby w osobnych liniach).
"""
with open('wyniki_3.txt','w') as file: 
    from random import randint
    sequence:list[int] = [randint(1,1000000) for _ in range(1,1000000)]
    help_list: list[int] = [0] * len(sequence)
    sort(sequence,0,len(sequence)-1)
    file.write('\n'.join(map(str,sequence)))
"""
Zadanie 4.
"""
