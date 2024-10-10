const cols = 47; // Liczba kolumn (oś x)
const rows = 20; // Liczba wierszy (oś y)
const cells = cols * rows; // Liczba komórek (x*y)
const life = "■";
const dead = "□";
let isOn = false; // Czy symulacja jest uruchomiona
let speed = 1000;
const speeds = [["Prędkość: wolno (1s)",1000],["Prędkość: średnio (0.5s)",500],["Prędkość: szybko (0.25s)",250],["Prędkość: bardzo szybko (0.1s)",100]];
let selectedSpeed = 1;

// Funkcja do stworzenia tabeli z planszą
function generateBoard(cols, rows) {
    const board = $('<table></table>');
    let id = 0;
    for (let i = 0; i < rows; i++) {
        const tr = $('<tr></tr>');
        for (let j = 0; j < cols; j++) {
            const td = $('<td></td>').text(dead).attr('id', `${id++}`);
            tr.append(td);
        }
        board.append(tr);
    }
    return board;
}

// Tworzenie planszy
$('#board').append(generateBoard(cols, rows));

function spawn(id)
{
    $("#" + id).html(life);
    $("#" + id).addClass("life");
}
function kill(id)
{
    $("#" + id).html(dead);
    $("#" + id).removeClassClass("life");
}

// Funkcja do zmiany pola na żywe/marwe po kliknięciu
$("td").on("click", function() {
    $(this).html() == life ? kill($(this).attr("id")) : spawn($(this).attr("id"));
});
// Funkcja do aktualizowania wartości speed
$('#bt-speed').on('click', function() { 
    if(selectedSpeed < speeds.length-1)
    {
        selectedSpeed++;
        speed = speeds[selectedSpeed][1];
        $('#bt-speed').html(speeds[selectedSpeed][0]);
    }
    else
    {
        selectedSpeed = 0
        speed = speeds[selectedSpeed][1];
        $('#bt-speed').html(speeds[selectedSpeed][0]);
    }
});

// Funkcja do obsługi przycisku czyszczenia (bez przywrócenia tego co było przed odpaleniem symulacji)
$("#bt-clear").on("click", function() {
    $("td").html(dead);
    $("td").removeClass("life");
    isOn?trigger():null;
});
// Funkcja do zliczania ilości sąsiadów danej komurki
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

    return (clu ? islife(id - cols - 1) : 0) +
           (cmu ? islife(id - cols) : 0) +
           (cru ? islife(id - cols + 1) : 0) +
           (clm ? islife(id - 1) : 0) +
           (crm ? islife(id + 1) : 0) +
           (cld ? islife(id + cols - 1) : 0) +
           (cmd ? islife(id + cols) : 0) +
           (crd ? islife(id + cols + 1) : 0);
}

// Funkcja do zwracania stanu komórki, czy jest żywa
function islife(id) {
    return $("#" + id).html() == life ? 1 : 0;
}
// Funkcja do akutalizacji stanu komórki
function lifeStatus(id) {
    let neighbours = findNeighbour(id);
    if ($("#" + id).html() == life && (neighbours != 2 && neighbours != 3)) {
        kill(id)
    } else if ($("#" + id).html() == dead && neighbours == 3) {
        spawn(id)
    }
}
// Funkcja do wykonania tury
function turn() {
    const newStates = Array(cells).fill(dead);
    for (let i = 0; i < cells; i++) {
        let neighbours = findNeighbour(i);
        if ($("#" + i).html() == life && (neighbours != 2 && neighbours != 3)) {
            newStates[i] = dead;
        } else if ($("#" + i).html() == dead && neighbours == 3) {
            newStates[i] = life;
        } else {
            newStates[i] = $("#" + i).html();
        }
    }
    $("td").removeClass("life");
    for (let i = 0; i < cells; i++) {
        $("#" + i).html(newStates[i]);
        if (newStates[i] == life)
            $("#" + i).addClass('life');
    }
}


$("#bt-one").on("click", turn);
$("#bt-onOff").on("click", trigger);
// Funkcja, która wykonuje kod po opóźnieniu
function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}
function trigger()
{ 
    isOn = isOn?false:true; 
    if (isOn)
    {
        $("#bt-onOff").html('Zatrzymaj Symulacje');
        $("#bt-onOff").addClass('running');
        $('#bt-one').attr('disabled', 'disabled')
        simulate();
    }
    else
    {
        $("#bt-onOff").html('Zacznij symulacje');
        $("#bt-onOff").removeClass('running');
        $('#bt-one').removeAttr('disabled');
    }
}
async function simulate()
{
    while (isOn)
    {
        turn();
        await sleep(speed);       
    }
}
