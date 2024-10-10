const cols = 47; // Liczba kolumn (oś x)
const rows = 20; // Liczna wierszy (oś y)
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
$("td").on("click", function() {$(this).html($(this).html() == "■"?"□":"■");});
// Funkcja do obsługi przycisku czyszczenia (bez przywrócenia tego co było przed odpaleniem symulacji)
$("#bt-clear").on("click", function() {$("td").html("□");});
function findNeighbour(id)
{
    // [clu] [cmu] [cru]
    // [clm] [id]  [crm]
    // [cld] [cmd] [crd]
    // Objaśnienie nazw:
    // clu → cell-left-up 
    // crd → cell-right-down 
    // cmu → cell-middle-up
    // itd…
    // » te zmienne sprawdzają czy dane komuóki istnieją
    /*
        00 01 02 03  => //
        04 05 06 07
        08 09 10 11
        
        co = 4
        ro = 3
        ce = 12
    */
    let cr = Math.floor(id/rows); // w którym wierszu
    let cc = Math.floor(id%cels); // w której kolumnie
    let cmu = cr > 0;
    let clm = cc > 0;
    let crm = cc < cells;
    let cmd = cr > rows;
    
    let clu = cmu && clm;
    let cru = cmu && crm;
    let cld = clm && cmd;
    let crd = cmd && crm;
    return clu?isLive(id-1-cols):0 + cmu?isLive(id-clos):0 + cru?isLive(id+1-cols):0 + clm?isLive(id-1):0 + crm?isLive(id+1):0 + cld?isLive(id-1+cols):0 + cmd?isLive(id+cols):0 + crd?isLive(id+1+cols):0
}
function isLive(id)
{
    return $(id).html() == "■"?1:0;
}
function lifeStatus(id)
{
    if($(id).html() == "■" && (findNeighbour(id) != 2    || findNeighbour(id) != 3))
    {
        $(id).html("□")
    }
    else if ($(id).html() == "□" && findNeighbour(id) == 3)
    {
        $(id).html("■")
    }
}
function turn()
{
    for(let i = 0; i<cells; i++)
    {
        lifeStatus(i);
    }
}
$("#bt-one").on("click",turn);