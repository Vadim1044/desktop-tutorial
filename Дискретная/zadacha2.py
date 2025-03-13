list = [                                [0,1,1,0,0,0],
                                        [1,0,1,0,0,0],
                                        [1,1,0,0,0,0],
                                        [0,0,0,0,1,1],
                                        [0,0,0,1,0,1],
                                        [0,0,0,1,1,0]] # матрица смежности n*m
verified_num = [1,2,3,4,5]
num_done = [0]
n = 0
m = 0
result = 0
temp = 0
for i in range(1,7):
    m=0
    if temp>(len(num_done)-1):
        n = verified_num[0]
        num_done.append(n)
        result+=1
    else:
        n = num_done[temp]
    
    for i in range(1,7):
        if list[n][m]==1:
            if m in verified_num:
                verified_num.remove(m)
            if not(m in num_done):
                num_done.append(m)
            m+=1
        else: m+=1
    temp+=1

print(result+1)