#include <iostream>
#include <vector>
#include <chrono>
#include <queue>

void dfs(int v, const std::vector<std::vector<int>>& graf, std::vector<bool>& visited) {
    visited[v] = true;
    std::cout << v << ' ';
    for (auto u: graf[v]) {
        if (!visited[u]) {
            dfs(u, graf, visited);
        }
    }
}
void bfs(int start, const std::vector<std::vector<int>>& graf) {
    auto visited = std::vector(graf.size(), false);
    auto q = std::queue<int>();

    visited[start] = true;
    q.push(start);

    while (!q.empty()) {
        auto v = q.front();
        q.pop();
        std::cout << v << ' ';
        for (auto u : graf[v]) {
            if (!visited[u]) {
                visited[u] = true;
                q.push(u);
            }
        }
    }
}

int main() {
    auto graf = std::vector<std::vector<int>>{
            {1,2,4},
            {0,2,4},
            {0,1,3,5},
            {2,4},
            {0,1,3,5},
            {2,4}
    };

    auto visited = std::vector(graf.size(), false);


    auto start = std::chrono::steady_clock::now();
    dfs(0, graf, visited);
    auto stop = std::chrono::steady_clock::now();
    std::cout << "\n" << std::chrono::duration<double, std::micro>(stop - start).count() << " µs\n";

    start = std::chrono::steady_clock::now();
    bfs(0, graf);
    stop = std::chrono::steady_clock::now();
    std::cout << "\n" << std::chrono::duration<double, std::micro>(stop - start).count() << " µs\n";
    return 0;
}
