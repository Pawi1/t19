"""
Zadania powtórkowe:
"""
"""
Zadanie 6
Napisz program, który wyświetli maksymalną sumę elementów spójnych podciągów ciągu,
znajdującego się w pierwszym wierszu pliku ciag.txt.
"""
def ex6():
    with open("ciag.txt") as file:
        sequence: list[int] = list(map(int,file.read().split()))
    length: int = len(sequence)
    max_sum: int = sequence[0]
    for seq_start in range(length):
        for seq_length in range(1, length - seq_start + 1):
            # print(sequence[seq_start:seq_start:seq_length])
            seq_sum = sum(sequence[seq_start:seq_start:seq_length])
            if max_sum < seq_sum:
                max_sum = seq_sum
    print(max_sum)
# Better use Kadane's algorithm