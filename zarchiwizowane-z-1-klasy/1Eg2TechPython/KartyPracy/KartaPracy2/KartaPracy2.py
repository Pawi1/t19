# Zadanie 1

print("Zadanie 1: Program, który sprawdzi, czy wpisana liczba jest podzialna przez 3")

print("Wpisz liczbe a:")
input_a = int(input())

if input_a%3==0:
 print("Tak")
else:
 print("Nie")

# Zadanie 2

print("Zadanie 2: Program, który sprawdzi, czy wpisana liczba jest trzycyfrowa i podzielna przez 17.")

print("Wpisz liczbe a:")
input_a = int(input())

if 100 <= input_a  >= 999 & input_a%17==0 :
 print("Tak")
else:
 print("Nie")

# Zadanie 3

print("Zadanie 3: Program, który sprawdzi, czy użytkownik jest osobą pełnoletnią")
print("Wpisz wiek:")
input_a = int(input())
if input_a<18:
 print("Jesteś niepełnoletni")
else:
 print("Jesteś pełnoletni")

# Zadanie 4

print("Zadanie 4: Program, który sprawdzi, czy ciężarówka może wjechać bezpiecznie na most. Max obciążenie mostu przyjmij na sztywno na 20 ton. Utwórz stałą o nazwie limit")
print("Wpisz wage:")
input_a = int(input())
if input_a>20:
 print("Nie możesz wjechać na most")
else:
 print("Możesz bezpiecznie wjechać na most")
 
# Zadanie 5 
# Przykłady:
# 3 6 5 – TAK
# 4 8 9 – NIE
# 3 8 3 – NIE
# 6 3 5 – TAK
print("Zadanie 5: Program, który sprawdzi, czy trzecia z podanych liczb mieści się między pierwszą a drugą. Weź pod uwagę, że kolejność wpisywania dwóch pierwszych liczb może nie być zachowana")

print("Wpisz liczbe a:")
input_a = int(input())
print("Wpisz liczbe b:")
input_b = int(input())
print("Wpisz liczbe c:")
input_c = int(input())

if (input_a < input_c and input_b > input_c) or (input_b < input_c and input_a > input_c):
  print("Mieści się")   
else: 
  print("Nie mieści")

# Zadanie 6

print ("Zadanie 6: Program, który sprawdzi, czy liczba pierwsza p spełnia Małe Twierdzenie Fermata. Stosujemy wersję MTF w formie: ”Jeśli p jest pierwsza to dla każdego a liczba a^p − a jest podzielna przez p”.")
print("Podaj dowolną liczbę:")
input_a = int(input())
print("Podaj liczbę pierwszą:")
input_p = int(input())
if (input_a ^ input_p - input_a ) % input_p == 0:
    print("Spełnia")
else:
    print("Nie spełnia")
    
# Zadanie 7

print ("Zadanie 7: Bajtożabka osiowa oddaje tylko równe skoki o długości s wzdłuż osi. Napisz algorytm, który sprawdzi, czy żabka pokona zadany dystans w trzech skokach. Jako punkt startu przyjmujemy wartość p, a jako punkt końcowy punkt k, gdzie p, k, s >= 0")
print("Podaj długość skoku:")
input_s = int(input())
print("Podaj punkt startu:")
input_p = int(input())
print("Podaj punkt końcowy:")
input_k = int(input())

if 3*input_s + input_p>= input_k:
    print("Tak")
else:
    print("NIE")