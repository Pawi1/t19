//- Zadania 1-3 dotyczą synchronizacji dostępu do wspólnego zasobu, zadania 4-5 dotyczą zarządzania wieloma wątkami naraz.
//- Do każdego zadania dopisz komentarzem, co dokładnie było przyczyną błędu / na czym polegało ryzyko wyścigu (race condition), zanim dodasz synchronizację.


//2. Wspólne konto bankowe [poziom: normalny]
//Napisz klasę KontoBankowe z polem saldo oraz zsynchronizowanymi metodami wplac(kwota) i wyplac(kwota).
// Metoda wyplac nie powinna pozwolić na spadek salda poniżej zera — jeśli brakuje środków, ma wypisać komunikat i nic nie zmieniać.
// Utwórz trzy wątki reprezentujące trzech klientów, którzy w pętli losowo wpłacają i wypłacają różne kwoty z tego samego konta.
// Uruchom je równolegle i sprawdź, czy saldo końcowe jest zawsze poprawne (zgodne z sumą operacji).

//3. Drukarka na cały wydział [poziom: normalny]
//Napisz klasę Drukarka z metodą drukuj(String dokument, String uzytkownik), która symuluje drukowanie (np. Thread.sleep(500)) i wypisuje, kto aktualnie korzysta z drukarki.
// Utwórz cztery wątki reprezentujące różnych użytkowników, którzy chcą jednocześnie wydrukować dokument na tej samej drukarce.
// Użyj bloku synchronized (a nie całej metody) tak, aby tylko jeden użytkownik naraz mógł korzystać z drukarki, a pozostali czekali w kolejce.

//4. Tablica wątków [poziom: normalny]
//Utwórz tablicę Thread[] watki o rozmiarze 5. W pętli utwórz 5 wątków, z których każdy wypisuje swój numer (0-4) oraz informację, że startuje, a następnie usypia się na losowy czas (Thread.sleep z losową wartością, np. 500-2000 ms).
// Uruchom wszystkie wątki z tablicy w jednej pętli, a w kolejnej, osobnej pętli wywołaj join() na każdym z nich — tak, aby program główny poczekał na zakończenie wszystkich wątków, zanim wypisze "Koniec programu".

//5. Równoległe sumowanie tablicy [poziom: docelowy]
//Masz dużą tablicę int[] liczby o rozmiarze np. 1 000 000, wypełnioną losowymi liczbami.
// Podziel tablicę na 4 równe fragmenty i utwórz tablicę Thread[4], gdzie każdy wątek liczy sumę swojego fragmentu i zapisuje wynik do wspólnej tablicy long[] czesciowe_sumy pod swoim indeksem
// (każdy wątek pisze wyłącznie do własnej komórki, więc synchronizacja tutaj nie jest potrzebna — zastanów się, dlaczego).
// Po zakończeniu wszystkich wątków (join()) zsumuj wartości z czesciowe_sumy i wypisz wynik końcowy.
// Zmierz czas wykonania (System.currentTimeMillis()) i porównaj z wersją jednowątkową, która liczy sumę całej tablicy w pojedynczej pętli.

void main()
{

}