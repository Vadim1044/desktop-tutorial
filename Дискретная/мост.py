class Graph:
    def __init__(self, graph):
        self.V = len(graph)
        self.graph = graph
        self.time = 0

    def bridge_util(self, u, visited, parent, low, disc):
        # Количество дочерних вершин в DFS
        children = 0

        # Отмечаем текущую вершину как посещенную и сохраняем время открытия
        visited[u] = True
        disc[u] = self.time
        low[u] = self.time
        self.time += 1

        # Проходим по всем вершинам, смежным с этой вершиной
        for v in range(self.V):
            if self.graph[u][v] == 1:
                # Если v еще не посещена, то рекурсивно вызываем функцию
                if not visited[v]:
                    parent[v] = u
                    children += 1
                    self.bridge_util(v, visited, parent, low, disc)

                    # Обновляем значение low[u] для родительской вершины
                    low[u] = min(low[u], low[v])

                    # Если u является корнем DFS и имеет два или более дочерних узлов,
                    # или если u не является корнем и low[v] >= disc[u], то (u, v) является мостом
                    if (parent[u] == -1 and children > 1) or (parent[u] != -1 and low[v] >= disc[u]):
                        print(f"Мост: ({u}, {v})")

                elif v != parent[u]:  # Обновляем значение low[u] только если v уже посещена и не является родителем
                    low[u] = min(low[u], disc[v])

    def bridge(self):
        # Отмечаем все вершины как не посещенные
        visited = [False] * self.V
        disc = [-1] * self.V
        low = [-1] * self.V
        parent = [-1] * self.V

        # Вызываем рекурсивную функцию для поиска мостов
        for i in range(self.V):
            if not visited[i]:
                self.bridge_util(i, visited, parent, low, disc)

# Пример использования
graph = [
    [0, 1, 0, 0, 0],
    [1, 0, 1, 1, 0],
    [0, 1, 0, 1, 0],
    [0, 1, 1, 0, 1],
    [0, 0, 0, 1, 0]
]

g = Graph(graph)
g.bridge()