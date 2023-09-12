
# # Zad 1
# n = int(input("Podaj n: "))
# for i in range(n): print("*-|", end="")


# # Zad 2

# n = int(input("Podaj n: "))
# for i in range(1, n+1):
#     print("*"*i, end="")
#     if i%2 == 1:
#         print("||",end="")
#     else:
#         print("--",end="")

# # Zad 3

# n = int(input("Podaj n: "))
# for i in range(1, n+1):
#     if i == 1 : print("*", end="")
#     print("|"*i, end="")
#     print("*", end="")
#     if i == 1 : print("-"*(i+1), end="")
#     else: print("-"*(i+2), end="")
#     print("*", end="")
#     print("|"*i, end="")
#     if i == n: print("|"*i, end="")

# # Zad 4

# n = int(input("Podaj n: "))

# for i in range(1,n+1):
#         print("\t"*(n-i),end="")
#         if i == 1:
#          print("*")
#         else:
#          print("*",end="")
#          print("\t"*(i*2-2),end="")
#          print("*")

# for i in range(n-1,1,-1):
#         print("\t"*(n-i),end="")
#         if i == 1:
#          print("*")
#         else:
#          print("*",end="")
#          print("\t"*(i*2-2),end="")
#          print("*")
# print("\t"*(n-1),end="") 
# print("*")

# # Zad 5
# print("Zadanie 5")
# n = int(input("Podaj n: "))

# for i in range ((n - int(n/2))):
#  print("   "*int(n/2),end=" ")
#  print("*")

# print(" — "*int(n/2),"*"," — "*int(n/2))

# for i in range ((n - int(n/2))):
#  print("   "*int(n/2),end=" ")
#  print("*")
# # Zad 6

print("Zadanie 6")
n = int(input("Podaj n: "))
for i in range(0,int(n/2)+1):
    if i == int(n/2) :print("\t"*(int(n/2)),"?")
    else :print("\t"*i,"*","\t"*(n-(2*i)-1),"?")   
for i in range(int(n/2)-1,-1,-1):
    print("\t"*i,"?","\t"*(n-(2*i)-1),"*")
