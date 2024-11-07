wej1 = input("b1: ")
wej2 = input("b2: ")
if len(wej1) != len(wej2): quit()

outp = ""
temp = ""
for i in range(len(wej1)): temp = '0'
print(temp)
for i in range(len(wej1)-1,0,-1): 
    b1 = int(wej1[i])
    b2 = int(wej2[i])
    bt = int(temp[i-1])
    if b1 + b2 + bt % 2 == 0:
        outp = '0' + outp
    else:
        outp = '1' + outp
    if b1 + b2 + bt > 2:
        temp[i+1] = '1'    
    print(outp)