#include <iostream>
#include <string>
#include <vector>
int zad1() {
    std::vector<std::string> knowWords = {"arbuz","lokomotywa","wiatrak","krowa","mleko","ananas","osada","krab", "auto",
        "but", "cukier", "dom", "echo", "farba", "góra", "hasło", "igła", "jabłko", "kot",
        "las", "łóżko", "miasto", "noc", "okno", "pies", "ryba", "stół", "śnieg", "telefon",
        "ucho", "woda", "zamek", "źrebię", "żaba"};

    while (true) {
        std::cout << "Podaj słowo (napisz d by zakończyć): ";
        std::string word = "";
        std::cin >> word;
        if (std::cin.eof() || word == "d") {
            break;
        }
        auto flag = true;
        for (auto know_word: knowWords) {
            if (word.ends_with(know_word[0])) {
                std::cout << know_word << std::endl;
                flag = false;
                break;
            }
        }
        if (flag) {
            std::cout << "Przegrałem" << std::endl;
        }
    }

    return 0;
}
int zad2() {
    std::string word,baseWord = "";
    std::cout << "Podaj słowo: ";
    std::cin >> word;
    std::cout << "Podaj słowo bazowe: ";
    std::cin >> baseWord;
    for (auto letter: word) {
        if (!baseWord.contains(letter)) {
            return 0;
        }
    }
    return 1;
}

int main() {
    auto result = zad2();
    std::cout << result << std::endl;
}