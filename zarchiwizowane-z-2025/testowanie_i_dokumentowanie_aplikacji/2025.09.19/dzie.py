n = int(input())
dzielniki = []
limit = int(n ** 0.5)
for i in range(1, limit + 1):
    if n % i == 0:
        dzielniki.append(i)
        if i != n // i:
            dzielniki.append(n // i)
dzielniki.sort()
for d in dzielniki:
    print(d)