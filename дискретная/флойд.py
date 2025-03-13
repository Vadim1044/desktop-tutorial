def floyd_warshall(graph, a, b):
    n = len(graph)
    dist = [[float('inf')]*n for _ in range(n)]
    for i in range(n):
        for j in range(n):
            if i == j:
                dist[i][j] = 0
            elif graph[i][j] is not None:
                dist[i][j] = graph[i][j]
    for k in range(n):
        for i in range(n):
            for j in range(n):
                if dist[i][k] + dist[k][j] < dist[i][j]:
                    dist[i][j] = dist[i][k] + dist[k][j]
    return dist[a][b]

def main():
    graph = [
        [0, 1, 4, 0],
        [1, 0, 2, 5],
        [4, 2, 0, 1],
        [0, 5, 1, 0]
    ]
    print("Введите первую вершину")
    a = int(input());
    print("Введите вторую вершину")
    b = int(input());
    result = floyd_warshall(graph, a, b)

    
    print(result)

if __name__ == "__main__":
    main();