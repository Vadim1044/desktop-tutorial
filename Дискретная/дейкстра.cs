def dijkstra(graph, start):
    num_vertices = len(graph)
    distances = [float('inf')] * num_vertices
    distances[start] = 0
    visited = [False] * num_vertices

    for _ in range(num_vertices):
        # Найти вершину с минимальным расстоянием, которая ещё не была посещена
        min_distance = float('inf')
        min_vertex = -1
        for v in range(num_vertices):
            if not visited[v] and distances[v] < min_distance:
                min_distance = distances[v]
                min_vertex = v

        # Если не найдено доступных вершин, завершаем алгоритм
        if min_vertex == -1:
            break

        # Пометить вершину как посещённую
        visited[min_vertex] = True

        # Обновить расстояния до соседних вершин
        for v in range(num_vertices):
            if graph[min_vertex][v] != 0 and not visited[v]:
                new_distance = distances[min_vertex] + graph[min_vertex][v]
                if new_distance < distances[v]:
                    distances[v] = new_distance

    return distances

def main():
    # Определение графа в виде массива смежности
    graph = [
        [0, 1, 4, 0],
        [1, 0, 2, 5],
        [4, 2, 0, 1],
        [0, 5, 1, 0]
    ]

    # Ввод начальной и конечной вершин
    start_vertex = int(input("Введите начальную вершину: "))
    end_vertex = int(input("Введите конечную вершину: "))

    # Выполнение алгоритма Дейкстры
    distances = dijkstra(graph, start_vertex)

    # Вывод кратчайшего расстояния до конечной вершины
    if distances[end_vertex] == float('inf'):
        print(f"Нет пути между вершинами {start_vertex} и {end_vertex}.")
    else:
        print(f"Кратчайшее расстояние между вершинами {start_vertex} и {end_vertex}: {distances[end_vertex]}")

if __name__ == "__main__":
    main()
