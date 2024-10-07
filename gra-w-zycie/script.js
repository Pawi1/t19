const cols = 47; // Liczba kolumn (oś x)
const rows = 20; // Liczna wierszy (oś y)
// Funkcja do stworzenia tabeli z planszą
function generateBoard(cols, rows) {
    const board = $('<table></table>');
    for (let i = 0; i < rows; i++) {
        const tr = $('<tr></tr>');
        for (let j = 0; j < cols; j++) {
            const td = $('<td></td>').text('□').attr('id', `${i}x${j}`);
            tr.append(td);
        }
        board.append(tr);
    }
    return board;
}
// Tworzenie planszy
$('#board').append(generateBoard(cols, rows));
// Funkcja do zmiany pola na żywe/marwe po kliknięciu
$("td").on("click", function() {$(this).html($(this).html() == "■"?"□":"■");});
// Funkcja do obsługi przycisku czyszczenia (bez przywrócenia tego co było przed odpaleniem symulacji)
$("#bt-clear").on("click", function() {$("td").html("□");});
// function find()
// {

// }