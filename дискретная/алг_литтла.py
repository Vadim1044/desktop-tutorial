def littl_algorithm(matrix):
    n = len(matrix)
    path = [0] * (n + 1)
    visited = [False] * n
    total_cost = 0
    current_node = 0

    for i in range(n):
        path[i] = current_node
        visited[current_node] = True

        next_node = -1
        min_cost = float('inf')

        for i in range(n):
            if not visited[i] and matrix[current_node][i] < min_cost:
                min_cost = matrix[current_node][i]
                next_node = i

        if next_node != -1:
            total_cost += min_cost
            current_node = next_node

    path[n] = path[0]
    total_cost += matrix[current_node][path[0]]

    print("Маршрут:", " -> ".join(map(str, path)))
    print("Общая стоимость:", total_cost)

# Исходная матрица
matrix = [
    [float('inf'), 13, 15, 10],
    [10, float('inf'), 25, 35],
    [11, 33, float('inf'), 40],
    [20, 22, 34, float('inf')]
]

littl_algorithm(matrix)