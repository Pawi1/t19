#include <iostream>
#include <string>
#include <vector>
#include <unordered_set>
#include <cstdlib>
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
std::string displayLetters(auto letters) {
    std::string letters_s = "[";
    for (const auto letter: letters) {
        letters_s += std::string(1,letter) + " ";
    }
    letters_s.replace(letters_s.length(),1,"]");
    return letters_s;
}

std::string uniqueLetters(std::string word) {
    std::string letters;
    for (auto letter: word) {
        if (!letters.contains(letter)) {
            letters += letter;
        }
    }
    return letters;
}

void zad3() {
    std::vector<std::string> board = {"\n\n\n\n\n\n\n\n",
        "\n\n\n\n\n\n\n   ▬▬▬▬▬▬▬▬▬▬\n",
        "           █\n           █\n           █\n           █\n           █\n           █\n           █\n   ▬▬▬▬▬▬▬▬▬▬\n",
        "       ▬▬▬▬█\n           █\n           █\n           █\n           █\n           █\n           █\n   ▬▬▬▬▬▬▬▬▬▬\n",
        "       ▬▬▬▬█\n      ○○   █\n      ○○   █\n           █\n           █\n           █\n           █\n   ▬▬▬▬▬▬▬▬▬▬\n",
        "       ▬▬▬▬█\n      ○○   █\n      ○○   █\n      ██   █\n      ██   █\n           █\n           █\n   ▬▬▬▬▬▬▬▬▬▬\n",
        "       ▬▬▬▬█\n      ○○   █\n      ○○   █\n     ▬██▬  █\n      ██   █\n           █\n           █\n   ▬▬▬▬▬▬▬▬▬▬\n",
        "       ▬▬▬▬█\n      ○○   █\n      ○○   █\n     ▬██▬  █\n      ██   █\n      ▌▐   █\n           █\n   ▬▬▬▬▬▬▬▬▬▬\n"
    };
    std::vector<std::string> words = {"arbuz","lokomotywa","wiatrak","krowa","mleko","ananas","osada","krab", "auto",
        "but", "cukier", "dom", "echo", "farba", "góra", "hasło", "igła", "jabłko", "kot",
        "las", "łóżko", "miasto", "noc", "okno", "pies", "ryba", "stół", "śnieg", "telefon",
        "ucho", "woda", "zamek", "źrebię", "żaba"};
    std::unordered_set<char> knowLetters;
    auto chosenWord = words[std::rand() % words.size()];
    auto chosenWord_letters = uniqueLetters(chosenWord);
    auto badAnswers= 0;
    while (badAnswers < chosenWord_letters.length()) {
        auto guess = false;
        std::string newLetters;

        std::cout << "\tWisielec:"<<std::endl;
        std::cout << board[badAnswers] << std::endl;
        std::cout << std::endl;
        std::cout << "Znane litery: " << displayLetters(knowLetters) << " (" << knowLetters.size() << "/" << chosenWord_letters.length() << ")" << std::endl;
        std::cout << "Podaj słowo: ";
        std::string word = "";
        std::cin >> word;
        for (auto letter: word) {
            if (chosenWord_letters.contains(letter)) {
                if (knowLetters.insert(letter).second) {
                    guess = true;
                    newLetters+=letter;
                }
            }
        }
        if (!guess) {
            badAnswers++;
            std::cout << "W szukanym słowie nie ma wspólnych liter…"<<std::endl;
        }
        else if (guess && (word != chosenWord)) {
            badAnswers++;
            std::cout << "Znalazłeś nowe litery: "<< displayLetters(newLetters) << std::endl;
        }
        else {
            std::cout << "Brawo odgadłeś słowo!" << std::endl;
            return;
        }
    }
    std::cout << "Przegrałeś, szukanym słowem było: " << chosenWord << std::endl;
}

int main() {
    zad3();
}