function formularz()
{
    // alert(document.getElementById("p1").value);
    let a = document.getElementById("a").value;
    let b = document.getElementById("b").value;
    document.getElementById("wynik").innerHTML = `${a*b} j²`;
    // alert(`Pole wynosi: ${a*b}`)
}