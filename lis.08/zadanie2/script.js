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