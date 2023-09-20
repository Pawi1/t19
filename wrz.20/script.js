function mnozenie(){
    while(true){
        a = prompt("Podaj a:","");
        b = prompt("Podaj b:","");
        ab =a*b;
        if(!isNaN(ab)){
             alert(`${a}*${b} = ${ab}`);
            break;
        }
        alert("Niepoprawne liczby, spróbuj ponownie")
    }    
}
function dzielenie(){
    while(true){
        a = prompt("Podaj a:","");
        b = prompt("Podaj b:","");
        ab = a/b;
        if(!isNaN(ab)){
            alert(`${a}:${b} = ${ab}`);
            break;
        }
        alert("Niepoprawne liczby, spróbuj ponownie")
    }
}
function dodawanie(){
    while(true){
        a = prompt("Podaj a:","");
        b = prompt("Podaj b:","");
        ab = a+b;
        if(!isNaN(ab)){
            alert(`${a}+${b} = ${ab}`);
            break;
        }
        alert("Niepoprawne liczby, spróbuj ponownie")
    }
}
function odejmanie(){
    while(true){
        a = prompt("Podaj a:","");
        b = prompt("Podaj b:","");
        ab = a-b;
        if(!isNaN(ab)){
            alert(`${a}-${b} = ${ab}`);
            break;
        }
        alert("Niepoprawne liczby, spróbuj ponownie")
    }
}