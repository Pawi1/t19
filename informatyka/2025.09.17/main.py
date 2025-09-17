""" Zadanie 4 """
roman_dict = {
    1000: "M",
    900:  "CM",
    500:  "D",
    400:  "CD",
    100:  "C",
    90:   "XC",
    50:   "L",
    40:   "XL",
    10:   "X",
    9:    "IX",
    5:    "V",
    4:    "IV",
    1:    "I",
}
roman_out:str = ""
arab_num:int = 2974
for num,rom in roman_dict.items():
    count = arab_num//num
    roman_out += count*rom
    arab_num %= num

print(roman_out)

""" Zadanie 5 """
arab_dict = {
    "M":   1000,
    "CM":   900,
    "D":    500,
    "CD":   400,
    "C":    100,
    "XC":    90,
    "L":     50,
    "XL":    40,
    "X":     10,
    "IX":     9,
    "V":      5,
    "IV":     4,
    "I":      1,
} 

arab_out:int = 0
roman_num:str = roman_out
for i in range(len(roman_num)):
    cur:int = arab_dict[roman_num[i]]
    if i + 1 < len(roman_num) and arab_dict[roman_num[i + 1]] > cur:
        arab_out -= cur
    else:
        arab_out += cur

print(arab_out)