import math

def find_bridges(adj_list):
    dfs_counter = 0
    n = len(adj_list) 
    dfs_ord = [math.inf] * n
    low_link = [math.inf] * n
    visited_vertices = [False] * n
    parent_vertex = [-1] * n
    for i in range(n):
        if visited_vertices[i] == False:
            dfs(i, visited_vertices, parent_vertex, low_link, dfs_ord, dfs_counter, adj_list)

def dfs(u, visited_vertices, parent_vertex, low_link, dfs_ord, dfs_counter, adj_list):
    visited_vertices[u] = True
    dfs_ord[u] = dfs_counter;
    low_link[u] =dfs_counter;
    dfs_counter += 1
    for v in adj_list[u]:
        if visited_vertices[v] ==False:
            parent_vertex[v] = u;
            dfs(v, visited_vertices, parent_vertex, low_link, dfs_ord, dfs_counter, adj_list)

            low_link[u] = min(low_link[u], low_link[v])
            if low_link[v] > dfs_ord[u]:
                print("мост " + str(u) + " -- " + str(v) + " ")

        elif v!= parent_vertex[u]:
            low_link[u] = min(low_link[u], dfs_ord[v])
            




def main():
    # Граф
    graph = [
    [1, 2],  # Вершина 0 соединена с вершинами 1 и 2
    [0, 2],  # Вершина 1 соединена с вершинами 0 и 2
    [0, 1, 3],  # Вершина 2 соединена с вершинами 0, 1 и 3
    [2, 4, 5],  # Вершина 3 соединена с вершинами 2, 4 и 5
    [3, 5],  # Вершина 4 соединена с вершинами 3 и 5
    [3, 4]   # Вершина 5 соединена с вершинами 3 и 4
]


    find_bridges(graph)

if __name__ == "__main__":
    main();