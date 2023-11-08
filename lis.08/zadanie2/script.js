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