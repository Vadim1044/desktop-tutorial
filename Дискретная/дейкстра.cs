def count(graph, start):
    num_vertices = len(graph);
    distances = [float('inf')] * num_vertices;
    distances[start] = 0;
    visited = [False] * num_vertices;

    for _ in range(num_vertices):
        min_distance = float('inf');
        min_vertex= -1;
        for v in range(num_vertices):
            if not visited[v] and distances[v] < min_distance:
                min_distance = distances[v];
                min_vertex = v;
        if min_vertex == -1:
            break;
        visited[min_vertex] = True;
        for v in range(num_vertices):
            if graph[min_vertex][v] !=0 and not visited[v]:
                new_distance = distances[min_vertex]+graph[min_vertex][v];
                if new_distance < distances[v]:
                    distances[v] = new_distance;
    return distances;

def main():
    # Граф
    graph = [
        [0, 1, 4, 0],
        [1, 0, 2, 5],
        [4, 2, 0, 1],
        [0, 5, 1, 0]
    ]

    start_vertex = int(input("Введите начальную вершину:"));
    end_vertex =int(input("Введите конечную вершину: "));
    # алгоритм Дейкстры
    distances = count(graph, start_vertex);
    if distances[end_vertex] == float('inf'):
        print(f"Нет пути.");
    else:
        print(f"Кратчайшее расстояние между этими вершинами: {distances[end_vertex]}");

if __name__ == "__main__":
    main();
