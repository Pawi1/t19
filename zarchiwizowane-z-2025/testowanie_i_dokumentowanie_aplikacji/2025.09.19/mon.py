_ = input()
inp = input().replace(" ", "")
cnt1:int = bin(int(inp, 2)).count('1')
cnt0:int = len(inp) - cnt1 - 1

if cnt0 < cnt1:
    print(cnt0)
else:
    print(cnt1)