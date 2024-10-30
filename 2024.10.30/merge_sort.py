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
