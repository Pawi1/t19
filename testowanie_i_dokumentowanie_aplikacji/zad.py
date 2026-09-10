a:int = int(input("Podaj a: "))
b:int = int(input("Podaj b: "))
while a != b:
    if a < b:
        b -= a
    else:
        a -= b
print(a)