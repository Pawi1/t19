// switch(prompt("Podaj imie",""))
// {
//     case "Adam":
//     {
//         alert("TEST");
//         break;
//     }
//     case "Adrian":
//     {
//         alert("Test");
//         break;
//     }
//     default:
//     {
//         alert("nie znam cię");
//     }
// }

let n = prompt("Podaj liczbe",""), x = prompt("Podaj potęge",""),w = n;
for(let i = 1;i<x;i++) w *= n; 
alert(w);