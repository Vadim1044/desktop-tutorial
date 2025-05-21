def kruskal(graph_matrix):
    edges = []
    n = len(graph_matrix);
    for i in range(n):
        for j in range(i+1, n): 
            weight = graph_matrix[i][j];
            if weight != 0: 
                edges.append((i, j, weight));
    
    def get_weight(edge):
        return edge[2]
    edges.sort(key=get_weight)
    
    parent = [i for i in range(n)];
    
    def find(u):
        while parent[u] != u:
            parent[u] = parent[parent[u]];
            u = parent[u];
        return u;
    
    total_weight = 0;
    mst_edges = [];
    
    for u, v, weight in edges:
        root_u = find(u);
        root_v = find(v);
        if root_u != root_v:
            parent[root_v] = root_u;
            total_weight += weight;
            mst_edges.append((u, v, weight))
            if len(mst_edges) == n - 1:
                break;
    
    print("Минимальное остовное дерево (рёбра):")
    for edge in mst_edges:
        print(f"{edge[0]} - {edge[1]} (вес: {edge[2]})");
    print(f"Общий вес: {total_weight}");
    return mst_edges, total_weight;
graph = [
    [0, 2, 0, 6, 0],
    [2, 0, 1, 8, 5],
    [0, 3, 0, 0, 7], 
    [6, 8, 0, 0, 9],
    [0, 5, 7, 9, 0]  
]

kruskal(graph);