def count(graph):
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
            if graph[n][m]==1:
                if m in verified_num:
                    verified_num.remove(m)
                if not(m in num_done):
                    num_done.append(m)
            m+=1
        temp+=1
    return result

def main():
    graph = [                           [0,1,1,0,0,0],
                                        [1,0,1,0,0,0],
                                        [1,1,0,0,0,0],
                                        [0,0,0,0,1,1],
                                        [0,0,0,1,0,1],
                                        [0,0,0,1,1,0]] # матрица смежности n*m
    result = count(graph)
    print(result+1)
if __name__ == "__main__":
    main();
