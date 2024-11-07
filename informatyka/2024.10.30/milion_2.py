def merge2(list1: list[int], list2: list[int]) -> list[int]:
    output_list: list[int] = []
    i: int = 0
    j: int = 0
    len_list1: int = len(list1)
    len_list2: int = len(list2)
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


def sort2(input_list: list[int]) -> list[int]:
    len_list = len(input_list)
    if len_list > 1:
        middle: int = (len_list - 1) // 2
        left: list[int] = sort2(input_list[: middle + 1])
        right: list[int] = sort2(input_list[middle + 1 :])
        return merge2(left, right)
    return input_list


"""
Zadanie 3.
Napisz program w języku Python, który wylosuje milion liczb
z zakresu od 1 do miliona, a następnie program zapisze ten ciąg posortowany 
metodą sortowania przez scalanie do pliku wyniki_3.txt (liczby w osobnych liniach).
"""
with open("wyniki_3.txt", "w") as file:
    from random import randint

    sequence: list[int] = [randint(1, 1000000) for _ in range(1, 1000000)]
    file.write("\n".join(map(str, sort2(sequence))))
