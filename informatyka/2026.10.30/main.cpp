#include <iostream>
#include <vector>
#include <array>
int main() {
    auto graf = std::array<std::array<int,6>,6>{{
        {0,1,1,0,1,0},
        {1,0,1,0,1,0},
        {1,1,0,1,0,1},
        {0,0,1,0,1,0},
        {1,1,0,1,0,1},
        {0,0,1,0,1,0}
    }};
    auto graf2 = std::vector<std::vector<int>>{
        {1,2,4},
        {0,2,4},
        {0,1,3,5},
        {2,4},
        {0,1,3,5},
        {2,4}
    };
    std::cout << "Hello, World!" << std::endl;
    return 0;
}
