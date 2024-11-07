# Algorytm szukający NWD - sposób odejmowanie  
a,b = int(input("1. Podaj a: ")),int(input("1. Podaj b: "))
while a!=b:
    if a>b : a-=b
    if b>a : b-=a
print(f"NWD = {a}")

# Algorytm szukający NWD - sposób modulo %
a,b = int(input("2. Podaj a: ")),int(input("2.Podaj b: "))
while b!=0 : a,b = b,a%b 
print(f"NWD = {a}")