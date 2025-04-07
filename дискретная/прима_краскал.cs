def find(parent, i):
    if parent[i] == -1:
        return i
    return find(parent, parent[i])

def union(parent, x, y):
    parent[x] = y

def prima_kruskal(vertices, edges):
    edges.sort(key=lambda edge: edge[2])

    parent = [-1] * vertices
    minimum_cost = 0
    result_edges = []

    for edge in edges:
        source, destination, weight = edge
        x = find(parent, source)
        y = find(parent, destination)

        if x != y:
            minimum_cost += weight
            result_edges.append(edge)
            union(parent, x, y)

    print("Вес оставного дерева:", minimum_cost)
    print("Рёбра остовного дерева:")
    for edge in result_edges:
        print(f"({edge[0]} -- {edge[1]}, вес: {edge[2]})")

def main():
    vertices = 4
    edges = [
        (0, 1, 10),
        (0, 2, 6),
        (0, 3, 5),
        (1, 3, 15),
        (2, 3, 4)
    ]

    prima_kruskal(vertices, edges)

if __name__ == "__main__":
    main();

