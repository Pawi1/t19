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


"""
Zadanie 3.
Napisz program w języku Python, który wylosuje milion liczb
z zakresu od 1 do miliona, a następnie program zapisze ten ciąg posortowany 
metodą sortowania przez scalanie do pliku wyniki_3.txt (liczby w osobnych liniach).
"""
with open("wyniki_3.txt", "w") as file:
    from random import randint

    sequence: list[int] = [randint(1, 1000000) for _ in range(1, 1000000)]
    help_list: list[int] = [0] * len(sequence)
    sort(sequence, 0, len(sequence) - 1)
    file.write("\n".join(map(str, sequence)))
