# ** Sposób modulo % **
a,b = int(input("1. Podaj a: ")),int(input("1.Podaj b: "))
sa,sb = a,b
while b!=0 : a,b = b,a%b 
# print(f"NWD = {a}")
print(f"NWW = {sa*sb//a}")
# ** Sposób odejmowanie **
a,b = int(input("1. Podaj a: ")),int(input("1. Podaj b: "))
sa,sb = a,b
while a!=b:
    if a>b : a-=b
    if b>a : b-=a
# print(f"NWD = {a}")
print(f"NWW = {sa*sb//a}")
