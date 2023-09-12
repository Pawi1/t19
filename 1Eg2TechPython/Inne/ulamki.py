import os 
def cls(): os.system('cls' if os.name=='nt' else 'clear')
cls()

a,b,c,d = int(input("1. A/B + C/D Podaj A: ")),int(input("1. A/B + C/D Podaj B: ")),int(input("1. A/B + C/D Podaj C: ")),int(input("1. A/B + C/D Podaj D: "))

sb,sd = b,d
while b!=d:
    if b>d : b-=d
    if d>b : d-=b

e = sb*sd//b
a2,c2 = a*e//sb,c*e//sd
print(f"\n{a}/{sb} + {c}/{sd} = {a2}/{e} + {c2}/{e} = {a2+c2}/{e} = {(a2+c2)/e}")

