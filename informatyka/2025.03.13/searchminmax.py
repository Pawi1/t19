from get_random_list import RandomList

random_list = RandomList(100, 1, 1000)
random_min = random_max = random_list[0]
for i in random_list:
    if i > random_max:
        random_max = i
    elif i < random_min:
        random_min = i
print(random_list)
print(random_min)
print(random_max)

"""
Wersja "zoptymalizowana"
"""
random_list = RandomList(100, 1, 1000)
if random_list[0] < random_list[0]:
    random_min = random_list[0]
    random_max = random_list[1]
else:
    random_min = random_list[1]
    random_max = random_list[0]
for i in range(2,len(random_list)-1):
    if random_list[i] < random_list[i+1]:
        if random_list[i+1] > random_max:
            random_max = random_list[i+1]
        elif random_list[i] < random_min:
            random_min = random_list[i]
    else:
        if random_list[i] > random_max:
            random_max = random_list[i]
        elif random_list[i+1] < random_min:
            random_min = random_list[i+1]
print(random_min)
print(random_max)