def parzysta(wej):
    if wej[-1] == '0':
        print("parzysta")
        return True
    else:
        print("nie parzysta")
        return False

wej = input("bin: ")
parzysta(wej)

wej1 = input("bin1: ")
wej2 = input("bin2: ")
# + -
if parzysta(wej1) == parzysta(wej2):
    print("parzysta")
else:
    print("nie parzysta")
# *
if parzysta(wej1) or parzysta(wej2):
    print("parzysta")
else:
    print("nie parzysta")

# 4 + 8 = parzysta
# 2 + 3 = nieparzyste
# 3 + 3 = parzysta
