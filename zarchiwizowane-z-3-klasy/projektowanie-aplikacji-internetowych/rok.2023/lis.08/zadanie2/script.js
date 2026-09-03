function funkcja()
{
    let f = document.getElementsByName("radio");
    let v;
    for(var i = 0;f.length>i;i++)
    {
        if(f[i].checked) v = f[i].value;
    }
    alert(v);
}
function funkcja2()
{
    let f = document.getElementsByName("ciastka");
    let v = "";
    for(var i = 0;f.length>i;i++)
    {
        if(f[i].checked) v += f[i].value + " ";
    }
    if(v=="") alert("Nic nie wybrano");
    else alert(`Masz ochote na: ${v}`);
}
function funkcja3() 
{
    var s = document.getElementById("ssaki");
    alert(`Value jest równy: ${s.value}`);
    alert(`selectedIndex zwraca wartość: ${s.selectedIndex}`);
    alert(`lenght zwraca wartość ${s.length}`);
}