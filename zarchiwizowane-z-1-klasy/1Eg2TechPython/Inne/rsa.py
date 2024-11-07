# pre 
# NWD = GCD
# from math import gcd
# print(gcd(12,14))

# 1. Wybór 2 dużych liczb pierwszych - przynajmniej 32 bity (najlepiej)
p = 97
q = 101
print(p,q)

# 2. Stworzenie funkcji Eulera F= (p-1) * (q-1) i znalezienie n = p*q
F = (p-1) * (q-1)
n = p * q
print(n)
print(F)

# 3. Znalezienie klucza publicznego e: NWD(F,e) = 1
e = 0
from math import gcd
for i in range(2,F):
    if gcd(i,F) == 1:
        e = i
        break

print(e,n) # klucz publiczny

# 4. Wygenerowanie klucza prywatnego d: d*e % F = 1 (odwrotność modulo)
d = 0
for i in range(2,n):
    if (i*e) % F == 1:
        d = i
        break
print(d,n)

# Przykład działania
# c = x**e mod n (na szyforogram)
# t = c**d mod n (na jawny)

msg = input()
szyfrogram = ""

for i in msg:
    szyfrogram += chr((ord(i)**e) % n)
print(szyfrogram)

jawny = ""

for j in szyfrogram:
    jawny += chr((ord(j)**d)%n)
print(jawny)