n = int(input())

smallest = None
largest  = None

for x in range(2, n):
    if n % x != 0:
        smallest = x
        break

for x in range(n - 1, 1, -1):
    if n % x != 0:
        largest = x
        break

print(f"{smallest} {largest}")
