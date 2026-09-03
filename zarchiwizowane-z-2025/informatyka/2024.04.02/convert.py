"""Napisz program obliczający sumę dwóch liczb binarnych podanych przez użytkownika.
Wynik podaj w systemie binarnym. Możesz wykorzystać pośrednią zamianę na system dziesiętnym."""
def bin_plus_bin(bin1:str,bin2:str)->str:
    bin_return:str = ""
    bin1_len = len(bin1)
    bin2_len = len(bin2)
    temp_digit:int = 0

    if bin1_len > bin2_len:
        bin2 = "0" * (bin1_len - bin2_len) + bin2
    elif bin1_len < bin2_len:
        bin1 = "0" * (bin2_len - bin1_len) + bin1
        bin1_len = bin2_len

    for i in range(bin1_len - 1, -1, -1):
        result: int = int(bin1[i]) + int(bin2[i]) + temp_digit
        if result > 1:
            temp_digit = 1
            result = result % 2
        else:
            temp_digit = 0
        bin_return = str(result) + bin_return
    if temp_digit == 1:
        bin_return = '1' + bin_return
    return bin_return

zad1_bin1:str = input("Podaj liczbę 1: ")
zad1_bin2:str = input("Podaj liczbę 2: ")
print(bin_plus_bin(zad1_bin1,zad1_bin2))
"""Napisz program obliczający sumę dwóch liczb w systemie o podstawie p (p w zakresie od 2 do 9). 
Liczby i podstawa są podawane przez użytkownika. Wynik podaj w systemie o podstawie p. Możesz wykorzystać pośrednią zamianę na system dziesiętnym."""
def n_plus_n(n1:str,n2:str,n:int)->str:
    n_return:str = ""
    n1_len = len(n1)
    n2_len = len(n2)
    temp_digit:int = 0

    if n1_len > n2_len:
        n2 = "0" * (n1_len - n2_len) + n2
    elif n1_len < n2_len:
        n1 = "0" * (n2_len - n1_len) + n1
        n1_len = n2_len

    for i in range(n1_len - 1, -1, -1):
        result: int = int(n1[i]) + int(n2[i]) + temp_digit
        if result >= n:
            temp_digit = result // n
            result = result % n
        else:
            temp_digit = 0
        n_return = str(result) + n_return

    if temp_digit > 0:
        n_return = str(temp_digit) + n_return
    return n_return
zad2_bin1:str = input("Podaj liczbę 1: ")
zad2_bin2:str = input("Podaj liczbę 2: ")
print(n_plus_n(zad1_bin1,zad1_bin2,2))



