#include <iostream>
#include <stack>
#include <string>

int rpn(const std::string& input) {
    auto stack = std::stack<int>();
    auto tmp = 0;
    for (auto c : input) {
        if (c == ' ') {
            stack.push(tmp);
        }
        else if (c < '0') {
            auto b = stack.top(); stack.pop();
            auto a = stack.top(); stack.pop();
            switch (c) {
                case '+':
                    stack.push(a + b);
                    break;
                case '-':
                    stack.push(a - b);
                    break;
                case '*':
                    stack.push(a * b);
                    break;
                case '/':
                    stack.push(a / b);
                    break;
            }
        }
        else {
            tmp = tmp * 10 + c - '0';
        }
    }
    return stack.top();
}


int main() {
    std::cout << "Hello, World!" << std::endl;
    return 0;
}
