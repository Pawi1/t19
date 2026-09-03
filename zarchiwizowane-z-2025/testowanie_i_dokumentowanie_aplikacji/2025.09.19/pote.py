s = input().strip()
mod4 = 0
for ch in s:
    mod4 = (mod4 * 10 + int(ch)) % 4
last = [6, 2, 4, 8]
print(last[mod4])