const cols = 47; // Liczba kolumn (oś x)
const rows = 20; // Liczba wierszy (oś y)
const cells = cols * rows; // Liczba komórek (x*y)

// Funkcja do stworzenia tabeli z planszą
function generateBoard(cols, rows) {
    const board = $('<table></table>');
    let id = 0;
    for (let i = 0; i < rows; i++) {
        const tr = $('<tr></tr>');
        for (let j = 0; j < cols; j++) {
            const td = $('<td></td>').text('□').attr('id', `${id++}`);
            tr.append(td);
        }
        board.append(tr);
    }
    return board;
}

// Tworzenie planszy
$('#board').append(generateBoard(cols, rows));

// Funkcja do zmiany pola na żywe/marwe po kliknięciu
$("td").on("click", function() {
    $(this).html($(this).html() == "■" ? "□" : "■");
});

// Funkcja do obsługi przycisku czyszczenia (bez przywrócenia tego co było przed odpaleniem symulacji)
$("#bt-clear").on("click", function() {
    $("td").html("□");
});

function findNeighbour(id) {
    let cr = Math.floor(id / cols); // w którym wierszu
    let cc = id % cols; // w której kolumnie

    let cmu = cr > 0;
    let clm = cc > 0;
    let crm = cc < cols - 1;
    let cmd = cr < rows - 1;

    let clu = cmu && clm;
    let cru = cmu && crm;
    let cld = cmd && clm;
    let crd = cmd && crm;

    return (clu ? isLive(id - cols - 1) : 0) +
           (cmu ? isLive(id - cols) : 0) +
           (cru ? isLive(id - cols + 1) : 0) +
           (clm ? isLive(id - 1) : 0) +
           (crm ? isLive(id + 1) : 0) +
           (cld ? isLive(id + cols - 1) : 0) +
           (cmd ? isLive(id + cols) : 0) +
           (crd ? isLive(id + cols + 1) : 0);
}

function isLive(id) {
    return $("#" + id).html() == "■" ? 1 : 0;
}

function lifeStatus(id) {
    let neighbours = findNeighbour(id);
    if ($("#" + id).html() == "■" && (neighbours != 2 && neighbours != 3)) {
        $("#" + id).html("□");
    } else if ($("#" + id).html() == "□" && neighbours == 3) {
        $("#" + id).html("■");
    }
}

function turn() {
    for (let i = 0; i < cells; i++) {
        lifeStatus(i);
    }
}

$("#bt-one").on("click", turn);
