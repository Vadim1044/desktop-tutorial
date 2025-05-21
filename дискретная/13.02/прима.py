def prima(matrix):
    num_vertices = len(matrix)
    selected = [False] * num_vertices
    selected[0] = True
    total_weight = 0

    while sum(selected) < num_vertices:
        min_weight = float('inf')
        x, y = 0, 0

        for i in range(num_vertices):
            if selected[i]:
                for j in range(num_vertices):
                    if not selected[j] and matrix[i][j] > 0:
                        if matrix[i][j] < min_weight:
                            min_weight = matrix[i][j]
                            x, y = i, j

        selected[y] = True
        total_weight += min_weight
        print(f"Добавляем ребро {x}-{y} с весом {min_weight}")

    print(f"Общий вес минимального остовного дерева: {total_weight}")
    return total_weight
matrix = [
    [0, 2, 6, 0, 0],
    [2, 0, 3, 8, 5],
    [6, 3, 0, 0, 7],
    [0, 8, 0, 0, 9],
    [0, 5, 7, 9, 0]
]

result = prima(matrix)