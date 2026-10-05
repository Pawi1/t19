#include <iostream>
#include <string>
#include <stack>
void zad1() {
    int input = 0;
    std::stack<int> stk;
    std::cout << "Podaj liczbę: ";
    std::cin >> input;

    while (input > 0) {
        stk.push(input%10);
        input /= 10;
    }
    const auto size = stk.size();
    for (auto i = 0; i < size; i++) {
        std::cout << stk.top() << std::endl;
        stk.pop();
    }
}

int prio(char c) {
    if (c == '+' || c == '-') return 1;
    if (c == '*' || c == '/' || c == '%') return 2;
    return 0;
}

void zad2() {
    std::string alg;
    std::cout << "Podaj wyrazenie: ";
    std::cin >> alg;

    std::string rpn = "";
    std::stack<char> stk;

    for (char chr : alg) {
        if (chr == '(') {
            stk.push(chr);
        } else if (chr == ')') {
            while (stk.top() != '(') {
                rpn += stk.top();
                stk.pop();
            }
            stk.pop();
        } else if (chr == '+' || chr == '-' || chr == '*' || chr == '/' || chr == '%') {
            while (!stk.empty() && prio(stk.top()) >= prio(chr)) {
                rpn += stk.top();
                stk.pop();
            }
            stk.push(chr);
        } else {
            rpn += chr;
        }
    }

    while (!stk.empty()) {
        rpn += stk.top();
        stk.pop();
    }

    std::cout << rpn << '\n';
}


int main() {
    zad1();
    return 0;
}
