print("Zadanie 1")
zad1 = input("Podaj napis: ")
print(zad1[0], zad1[len(zad1)-1]) #?   |  
print(zad1[0], zad1[-1])          #? <-| to samo

print("Zadanie 2")
zad2 = zad1
print(zad2[1:-1])

print("Zadanie 3")
zad3 = zad2
print(zad3[-1:-5:-1])

print("Zadanie 4")
zad4 = zad3
s = 0
for i in zad4:
    s += ord(i)
print(s)

print("Zadanie 5")
zad5 = zad4
ilosc = 0
for i in zad5:
    if i == 'a' or i == 'A':
        ilosc +=1
print(ilosc)

print ("Zadanie 6")
zad6 = zad5
maks = 0
literka = ""
for i in range(len(zad6)):
   pre = zad6.count(zad6[i])
   if pre > maks: 
    maks = pre 
    literka = zad6[i]
print("Literka",literka,"wystąpiła",maks,"razy")

print("Zadanie 7")
zad7 = zad6
array = [""]
array2 = []
pop = False
for i in zad7:
   for x in array:
    if x == i: 
         set = False
         break
    else:
       set = True
   if set == True: 
    array.append(i)
    array2.append(zad7.count(i))
    print("Literka",i,"wystąpiła",zad7.count(i),"razy")
    if pop == False:
        array.pop(0)
        pop = True
print(array,array2)
def Klucz(e):
   return e[1]
array3 = [] 
for y in range(len(array)):
    array3.append(array[y]+str(array2[y]))
print(array3)
array3.sort(reverse=True,key=Klucz)
print(array3) 

print("Dominantem jest:")
i = 0
while(True):
    a = array3[0+i]
    b = array3[1+i]
    if a[1] > b[1]:
        print(a[0])
        break
    elif a[1] == b[1]:
       print(a[0])
       i+=1
    else:
       i+=1



# for m in range(len(array3)):
#     a = array3[0+i]
#     b = array3[1+i]
#     if a[1] != b[1]:
#         print(a[0])
#     else:
#         i=+1
   