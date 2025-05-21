def dijkstra(matrix, start):
    n = len(matrix);
    distances = [float('inf')] * n;
    distances[start] = 0;
    visited = [False] * n;

    for _ in range(n):
        min_dist = float('inf');
        u = -1;
        for v in range(n):
            if not visited[v] and distances[v] < min_dist:
                min_dist = distances[v]
                u = v
        
        if u == -1: 
            break;
        
        visited[u] = True;

        for v in range(n):
            if matrix[u][v] != 0 and not visited[v]:
                new_dist = distances[u] + matrix[u][v]
                if new_dist < distances[v]:
                    distances[v] = new_dist;

    return distances;

graph_matrix = [
    [0, 1, 4, 0],
    [1, 0, 2, 5],
    [4, 2, 0, 1],
    [0, 5, 1, 0]
]

start_node = int(input("Введите начальную вершину:"));
end_node =int(input("Введите конечную вершину: "));
distances = dijkstra(graph_matrix, start_node)

print(distances);
print(f"Кратчайшее расстояние между этими вершинами: {distances[end_node]}");