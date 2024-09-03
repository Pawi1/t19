## konwersja DEC -> BIN
# 37[10] = 100101[2]
def DecToBin(inp):
    if inp == 0: return str(0)
    out = ""
    while inp > 0:
        out = str(inp%2) + out
        inp //= 2
    return out
# rekurencyjnie
def Dec2Bin(inp):
    if inp == 0: return ""
    return Dec2Bin(inp//2) + str(inp%2)

print("inp: ")
print(DecToBin(37))
print(Dec2Bin(37))

## konwersja BIN -> DEC
#  1; 0;0;1;0;1 [2] = 37[10]
# 32;16;8;4;2;1 
def BinToDec(inp):
    out = 0
    for i in range(len(inp)):
        if inp[len(inp)-1-i] == '1':
            out += 2**i
    return out
def BinToDecHomer(inp):
    out = 0
    for i in range(len(inp)):
        out = out * 2 + int[inp[i]]
    return out
# def Bin2Dec(inp):
#     if len(inp) == 0: return ""


print("inp: 100101")
print(BinToDec("100101"))