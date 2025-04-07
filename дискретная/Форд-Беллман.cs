def bellman_ford(num_vertices, edges, fisrt_vertice):
    distances = [float('inf')] * num_vertices
    distances[fisrt_vertice] = 0
    for _ in range(num_vertices - 1):
        for u, v, w in edges:
            if distances[u] != float('inf') and distances[u] + w < distances[v]:
                distances[v] = distances[u] + w
    for u, v, w in edges:
        if distances[u] != float('inf') and distances[u] + w < distances[v]:
            print("граф содержит цикл с отрицательным весом")
            return None

    return distances

if __name__ == "__main__":
    num_vertices = 5
    edges = [
        (0, 1, 6),
        (0, 2, 7),
        (1, 2, 8),
        (1, 3, -4),
        (1, 4, 5),
        (2, 3, 9),
        (2, 4, -3),
        (3, 4, 7)
    ]
    fisrt_vertice = 0

    distances = bellman_ford(num_vertices, edges, fisrt_vertice)
    print(f"расстояние от вершины {fisrt_vertice} до всех: ")
    for i in range(num_vertices):
            print(f"{i}\t\t{distances[i]}")