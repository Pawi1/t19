from math import sqrt
# Algorytm sprawdzający czy liczba jest liczbą pierwszą
# n = int(input("1. Wpisz liczbę: "))
# b = 0
# for i in range(2,n):
#     if n%i==0: 
#         b=1 
#         break
# if b==0: print("tak") 
# else: print("nie")

# funkcja

# def czyPierwsza(n):
#     bol = True
#     for i in range(2,int(sqrt(n)) + 1):
#         if n % i == 0: 
#             bol = False
#             break
#         return(bol)

# n = int(input("1. Wpisz liczbę: "))
# if czyPierwsza(n) == True: print("tak") 
# elif czyPierwsza(n) == False: print("nie")  
# Genarator liczb pierwszych - liczby pierwsze w przedziale 21.11
## p = int(input("2. Wpisz od:")) 
# q = int(input("2. Wpisz do:"))
# for i in range(p,q+1):
#     flag = True
#     for j in range(2,int(i**0.5)+1):
#         if i % j == 0:
#             flag = False
#     if flag == True:
#         print(i, end=" ")

n = int(input("3. Wpisz do:"))
x = 2
while 1:
  flaga = True
  for i in range(2,int(x**0.5)+1):
    if x%i ==0:
        flaga = False
  if flaga:
    print(x,end=" ")
    n=n-1
    if n==0:
        break
  x+=1      