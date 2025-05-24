class Graph:
    def __init__(self, matrix):
        if len(matrix) != len(matrix[0]):
            raise ValueError("Некорректная матрица")
        
        self.matrix = matrix
        self.n = len(matrix)
        self.visited = [False] * self.n
        self.best_path = [];
        self.best_cost = float('inf')
    
    def find_cycle(self, level=1, cost=0, path=None, bound=None):
        if path == None:
            path = [0] * (self.n + 1)
            path[0] = 0;
            self.visited[0] = True;
            bound = self.calc_bound();
        
        if level == self.n:
            self.check_path(path, cost)
            return;
        
        for v in range(self.n):
            if self.can_visit(path[level-1], v):
                new_cost = cost + self.matrix[path[level-1]][v]
                new_bound = self.update_bound(level, path[level-1], v, bound)
                
                if new_cost + new_bound < self.best_cost:
                    path[level] = v
                    self.visited[v] = True;
                    self.find_cycle(level+1, new_cost, path, new_bound)
                    self.visited[v] = False;
    
    def can_visit(self, u, v):
        return self.matrix[u][v] and not self.visited[v]
    
    def check_path(self, path, cost):
        return_cost = self.matrix[path[-2]][path[0]]
        if return_cost and (total := cost + return_cost) < self.best_cost:
            self.best_path = path[:-1] + [path[0]]
            self.best_cost = total;
    
    def update_bound(self, level, u, v, bound):
        if level == 1:
            return bound - (self.min_edge(u) + self.min_edge(v)) // 2
        return bound - self.min_edge(u) // 2
    
    def min_edge(self, u):
        costs = [x for x in self.matrix[u] if x]
        return min(costs) if costs else float('inf')
    
    def calc_bound(self):
        total = sum(self.min_edge(i) for i in range(self.n))
        return total // 2 if total else 0


def main():
    graph = [
        [0, 20, 15, 13],
        [9, 10, 88, 20],
        [9, 15, 0, 44],
        [24, 29, 15, 0]
    ]
    
    try:
        solver = Graph(graph)
        solver.find_cycle()
        
        if solver.best_cost != float('inf'):
            print("Найден цикл:");
            print("Путь:", " → ".join(map(str, solver.best_path)));
            print("Стоимость:", solver.best_cost);
        else:
            print("Цикл не найден");
    except Exception as e:
        print(f"Ошибка: {e}");


if __name__ == "__main__":
    main()