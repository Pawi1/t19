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
int zad3() {
    std::string rpn;
    std::cout << "Podaj wyrazenie: ";
    std::cin >> rpn;
    std::stack<int> stk;
    for (auto chr : rpn) {
        if (chr >= '0' && chr <= '9') {
            stk.push(chr - '0');
        }
        else {
            int a,b;
            b = stk.top(); stk.pop();
            a = stk.top(); stk.pop();
            switch (chr) {
                case '+':
                    stk.push(a+b);
                    break;
                case '-':
                    stk.push(a-b);
                    break;
                case '*':
                    stk.push(a*b);
                    break;
                case '/':
                    stk.push(a/b);
                    break;
                case '%':
                    stk.push(a%b);
                    break;
                default:
                    break;
            }
        }
    }
    std::cout << stk.top() << '\n';
    return stk.top();
}

bool zad4() {
    std::string brackets;
    std::cout << "Podaj napis: ";
    std::cin >> brackets;
    std::stack<char> stk;
    for (auto chr : brackets) {
        if (chr == '(' || chr == '[' || chr == '{') {
            stk.push(chr);
        }
        else {
            if (stk.empty()) {
                std::cout << "NIE" << '\n';
                return false;
            }
            const auto bracket = stk.top();stk.pop();
            // właściwość umiejscowienia nawiasów w tabeli ascii
            if (bracket + 1 != chr && bracket + 2 != chr) {
                std::cout << "NIE" << '\n';
                return false;
            }
        }
    }
    if (stk.empty()) {
        std::cout << "TAK" << '\n';
        return true;
    }
    std::cout << "NIE" << '\n';
    return false;
}
bool zad5() {
    std::string rpn;
    std::cout << "Podaj wyrazenie: ";
    std::cin >> rpn;
    std::stack<int> stk;
    for (auto chr : rpn) {
        if (chr >= '0' && chr <= '9') {
            stk.push(chr - '0');
        }
        else if (chr == '+' || chr == '-' || chr == '*' || chr == '/') {
            if (stk.size() < 2) {
                std::cout << "NIE" << '\n';
                return false;
            }
            int a,b;
            b = stk.top(); stk.pop();
            a = stk.top(); stk.pop();
        }
    }
    std::cout << stk.top() << '\n';
    return stk.top();
}
int main() {

    return 0;
}
