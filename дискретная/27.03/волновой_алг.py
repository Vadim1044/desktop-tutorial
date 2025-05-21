def wave(maze, start, end):
    if maze[start[0]][start[1]] == 1 or maze[end[0]][end[1]] == 1:
        return None
    directions = [(-1, 0), (1, 0), (0, -1), (0, 1)]
    rows = len(maze)
    cols = len(maze[0]) if rows > 0 else 0
    wave_map = []
    
    for i in range(rows):
        row = []
        for j in range(cols):
            row.append(-1)
        wave_map.append(row)

    wave_map[start[0]][start[1]] = 0
    
    queue = [start]

    while queue:
        x, y = queue.pop(0)
        
        for dx, dy in directions:
            nx, ny = x + dx, y + dy
            if (0 <= nx < rows and 0 <= ny < cols 
                and maze[nx][ny] == 0 and wave_map[nx][ny] == -1):
                wave_map[nx][ny] = wave_map[x][y] + 1
                queue.append((nx, ny))
                
                if (nx, ny) == end:
                    queue = []
                    break
    
    if wave_map[end[0]][end[1]] == -1:
        return None
    
    path = []
    x, y = end
    path.append((x, y))
    
    while (x, y) != start:
        for dx, dy in directions:
            nx, ny = x + dx, y + dy
            if (0 <= nx < rows and 0 <= ny < cols):
                if wave_map[nx][ny] == wave_map[x][y] - 1:
                    path.append((nx, ny))
                    x, y = nx, ny
                    break
    
    return path[::-1]

# 0 - проход, 1 - препятствие
maze = [
    [0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0],
    [1, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0],
    [0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 1, 0],
    [0, 1, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0],
    [0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 0],
    [0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 1, 0],
    [0, 1, 0, 0, 0, 1, 1, 1, 1, 0, 1, 0],
    [0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0],
    [0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1],
    [0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0],
]
start = (0, 0)
end = (9, 11)

path = wave(maze, start, end)

if path:
    print("Кратчайший путь:")
    for point in path:
        print(point)
else:
    print("Путь не найден")