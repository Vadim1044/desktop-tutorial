def components(matrix):
    n = len(matrix)
    visited = [False] * n
    components = 0
    
    for vertex in range(n):
        if not visited[vertex]:
            components += 1
            dfs(vertex, matrix, visited)
    
    return components

def dfs(current_vertex, matrix, visited):
    visited[current_vertex] = True
    
    for neighbor in range(len(matrix)):
        if matrix[current_vertex][neighbor] == 1 and not visited[neighbor]:
            dfs(neighbor, matrix, visited)

# Пример использования
if __name__ == "__main__":
    # Матрица смежности графа
    matrix = [
                                        [0,1,1,0,0,0],
                                        [1,0,1,0,0,0],
                                        [1,1,0,0,0,0],
                                        [0,0,0,0,1,1],
                                        [0,0,0,1,0,1],
                                        [0,0,0,1,1,0]
    ]
    
print(components(matrix))